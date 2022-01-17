using Common;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StatsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Country c;
            LoadJson();
        }

        public void LoadJson()
        {
            DateTime StartPoint = DateTime.Now.Subtract(TimeSpan.FromDays(120));
            using (StreamReader r = new StreamReader("owid-covid-data (1).json"))
            {
                string json = r.ReadToEnd();
                Dictionary<string, Country> items = JsonConvert.DeserializeObject<Dictionary<string, Country>>(json);
                foreach (var kvp in items.Select(kvp => kvp.Value))
                {
                    var relevantData = kvp.Data.Where(d => d.Date >= StartPoint).ToList();
                    double percentVacMin = relevantData.Min(d => d.PeopleFullyVaccinatedPerHundred) ?? 0;
                    double percentVacMax = relevantData.Max(d => d.PeopleFullyVaccinatedPerHundred) ?? 0;
                    double deathWithinInterval = relevantData.Sum(d => d.NewDeathsPerMillion) ?? 0;
                    dataGridView1.Rows.Add(kvp.Continent,
                        kvp.Location,
                        kvp.Population,
                        kvp.PopulationDensity,
                        percentVacMin,
                        percentVacMax,
                        deathWithinInterval);
                    if (string.IsNullOrEmpty(kvp.Continent) == false && clb_Continent.Items.Contains(kvp.Continent) == false)
                    {
                        clb_Continent.Items.Add(kvp.Continent);
                        clb_Continent.SetItemChecked(clb_Continent.Items.Count - 1, kvp.Continent.ToLower() == "europe");
                    }
                }
            }
            HideUnhideRows();
        }

        private void clb_Continent_SelectedIndexChanged(object sender, EventArgs e)
        {
            HideUnhideRows();
        }

        private bool IsContinentChecked(Dictionary<string, bool> dicCheckedContinent, string sContinent)
        {
            if (dicCheckedContinent.ContainsKey(sContinent ?? String.Empty) == false)
                return false;

            return dicCheckedContinent[sContinent];
        }

        private void HideUnhideRows()
        {
            Dictionary<string, bool> dicCheckedContinent = new Dictionary<string, bool>();
            int count = 0;
            foreach (var item in clb_Continent.Items)
            {
                dicCheckedContinent.Add(item.ToString(), clb_Continent.GetItemChecked(count));
                count++;
            }
            for (int row = 0; row < dataGridView1.Rows.Count; row++)
            {
                if (dataGridView1.Rows[row].IsNewRow)
                    continue;

                dataGridView1.Rows[row].Visible = IsContinentChecked(dicCheckedContinent, dataGridView1[0, row]?.Value?.ToString()) && (ToInt(dataGridView1[2, row]?.Value.ToString()) > 1_000_000);
            }
        }

        private void cb_LargePopOnly_CheckedChanged(object sender, EventArgs e)
        {

            HideUnhideRows();
        }

        private int ToInt(string s)
        {
            if(int.TryParse(s, out var i))
            {
                return i;
            }
            return 0;
        }
    }
}

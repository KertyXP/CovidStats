
namespace StatsForm
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.clb_Continent = new System.Windows.Forms.CheckedListBox();
            this.Continent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Country = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.density = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VaccMin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VaxMax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Death = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cb_LargePopOnly = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Continent,
            this.Country,
            this.Pop,
            this.density,
            this.VaccMin,
            this.VaxMax,
            this.Death});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(794, 394);
            this.dataGridView1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // clb_Continent
            // 
            this.clb_Continent.FormattingEnabled = true;
            this.clb_Continent.Location = new System.Drawing.Point(3, -1);
            this.clb_Continent.Name = "clb_Continent";
            this.clb_Continent.Size = new System.Drawing.Size(120, 49);
            this.clb_Continent.TabIndex = 1;
            this.clb_Continent.SelectedIndexChanged += new System.EventHandler(this.clb_Continent_SelectedIndexChanged);
            // 
            // Continent
            // 
            this.Continent.HeaderText = "Continent";
            this.Continent.Name = "Continent";
            // 
            // Country
            // 
            this.Country.HeaderText = "Country";
            this.Country.Name = "Country";
            // 
            // Pop
            // 
            this.Pop.HeaderText = "Pop";
            this.Pop.Name = "Pop";
            // 
            // density
            // 
            this.density.HeaderText = "density";
            this.density.Name = "density";
            // 
            // VaccMin
            // 
            this.VaccMin.HeaderText = "Vacc Min";
            this.VaccMin.Name = "VaccMin";
            // 
            // VaxMax
            // 
            this.VaxMax.HeaderText = "Vax Max";
            this.VaxMax.Name = "VaxMax";
            // 
            // Death
            // 
            this.Death.HeaderText = "Death";
            this.Death.Name = "Death";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cb_LargePopOnly);
            this.panel1.Controls.Add(this.clb_Continent);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(794, 44);
            this.panel1.TabIndex = 2;
            // 
            // cb_LargePopOnly
            // 
            this.cb_LargePopOnly.AutoSize = true;
            this.cb_LargePopOnly.Location = new System.Drawing.Point(146, 10);
            this.cb_LargePopOnly.Name = "cb_LargePopOnly";
            this.cb_LargePopOnly.Size = new System.Drawing.Size(111, 17);
            this.cb_LargePopOnly.TabIndex = 2;
            this.cb_LargePopOnly.Text = "Large Pop (> 1 M)";
            this.cb_LargePopOnly.UseVisualStyleBackColor = true;
            this.cb_LargePopOnly.CheckedChanged += new System.EventHandler(this.cb_LargePopOnly_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.CheckedListBox clb_Continent;
        private System.Windows.Forms.DataGridViewTextBoxColumn Continent;
        private System.Windows.Forms.DataGridViewTextBoxColumn Country;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pop;
        private System.Windows.Forms.DataGridViewTextBoxColumn density;
        private System.Windows.Forms.DataGridViewTextBoxColumn VaccMin;
        private System.Windows.Forms.DataGridViewTextBoxColumn VaxMax;
        private System.Windows.Forms.DataGridViewTextBoxColumn Death;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox cb_LargePopOnly;
    }
}


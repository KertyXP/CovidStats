using Newtonsoft.Json;

namespace Common
{

    public partial class Country
    {
        [JsonProperty("continent")]
        public string Continent { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("population")]
        public long Population { get; set; }

        [JsonProperty("population_density")]
        public double PopulationDensity { get; set; }

        [JsonProperty("median_age")]
        public double MedianAge { get; set; }

        [JsonProperty("aged_65_older")]
        public double Aged65_Older { get; set; }

        [JsonProperty("aged_70_older")]
        public double Aged70_Older { get; set; }

        [JsonProperty("gdp_per_capita")]
        public double GdpPerCapita { get; set; }

        [JsonProperty("diabetes_prevalence")]
        public double DiabetesPrevalence { get; set; }

        [JsonProperty("life_expectancy")]
        public double LifeExpectancy { get; set; }



        [JsonProperty("cardiovasc_death_rate")]
        public double CardiovascDeathRate { get; set; }


        [JsonProperty("handwashing_facilities")]
        public double HandwashingFacilities { get; set; }

        [JsonProperty("hospital_beds_per_thousand")]
        public double HospitalBedsPerThousand { get; set; }


        [JsonProperty("human_development_index")]
        public double HumanDevelopmentIndex { get; set; }


        [JsonProperty("data")]
        public Datum[] Data { get; set; }
    }
}

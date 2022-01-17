using Newtonsoft.Json;
using System;

namespace Common
{
    public partial class Datum
    {
        [JsonProperty("date")]
        public DateTimeOffset Date { get; set; }

        [JsonProperty("total_vaccinations", NullValueHandling = NullValueHandling.Ignore)]
        public long? TotalVaccinations { get; set; }

        [JsonProperty("people_vaccinated", NullValueHandling = NullValueHandling.Ignore)]
        public long? PeopleVaccinated { get; set; }

        [JsonProperty("people_fully_vaccinated", NullValueHandling = NullValueHandling.Ignore)]
        public long? PeopleFullyVaccinated { get; set; }

        [JsonProperty("total_vaccinations_per_hundred", NullValueHandling = NullValueHandling.Ignore)]
        public double? TotalVaccinationsPerHundred { get; set; }

        [JsonProperty("people_vaccinated_per_hundred", NullValueHandling = NullValueHandling.Ignore)]
        public double? PeopleVaccinatedPerHundred { get; set; }

        [JsonProperty("people_fully_vaccinated_per_hundred", NullValueHandling = NullValueHandling.Ignore)]
        public double? PeopleFullyVaccinatedPerHundred { get; set; }

        [JsonProperty("stringency_index", NullValueHandling = NullValueHandling.Ignore)]
        public double? StringencyIndex { get; set; }

        [JsonProperty("new_vaccinations_smoothed", NullValueHandling = NullValueHandling.Ignore)]
        public long? NewVaccinationsSmoothed { get; set; }

        [JsonProperty("new_vaccinations_smoothed_per_million", NullValueHandling = NullValueHandling.Ignore)]
        public long? NewVaccinationsSmoothedPerMillion { get; set; }

        [JsonProperty("new_people_vaccinated_smoothed", NullValueHandling = NullValueHandling.Ignore)]
        public long? NewPeopleVaccinatedSmoothed { get; set; }

        [JsonProperty("new_people_vaccinated_smoothed_per_hundred", NullValueHandling = NullValueHandling.Ignore)]
        public double? NewPeopleVaccinatedSmoothedPerHundred { get; set; }

        [JsonProperty("new_vaccinations", NullValueHandling = NullValueHandling.Ignore)]
        public long? NewVaccinations { get; set; }



        [JsonProperty("total_cases")]
        public long TotalCases { get; set; }

        [JsonProperty("new_cases")]
        public long NewCases { get; set; }

        [JsonProperty("total_cases_per_million")]
        public double TotalCasesPerMillion { get; set; }

        [JsonProperty("new_cases_per_million")]
        public double NewCasesPerMillion { get; set; }

        [JsonProperty("new_cases_smoothed", NullValueHandling = NullValueHandling.Ignore)]
        public double? NewCasesSmoothed { get; set; }

        [JsonProperty("new_deaths_smoothed", NullValueHandling = NullValueHandling.Ignore)]
        public double? NewDeathsSmoothed { get; set; }

        [JsonProperty("new_cases_smoothed_per_million", NullValueHandling = NullValueHandling.Ignore)]
        public double? NewCasesSmoothedPerMillion { get; set; }

        [JsonProperty("new_deaths_smoothed_per_million", NullValueHandling = NullValueHandling.Ignore)]
        public double? NewDeathsSmoothedPerMillion { get; set; }

        [JsonProperty("total_deaths", NullValueHandling = NullValueHandling.Ignore)]
        public long? TotalDeaths { get; set; }

        [JsonProperty("new_deaths", NullValueHandling = NullValueHandling.Ignore)]
        public long? NewDeaths { get; set; }

        [JsonProperty("total_deaths_per_million", NullValueHandling = NullValueHandling.Ignore)]
        public double? TotalDeathsPerMillion { get; set; }

        [JsonProperty("new_deaths_per_million", NullValueHandling = NullValueHandling.Ignore)]
        public double? NewDeathsPerMillion { get; set; }

        [JsonProperty("reproduction_rate", NullValueHandling = NullValueHandling.Ignore)]
        public double? ReproductionRate { get; set; }
    }
}

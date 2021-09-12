using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class CarCrashViewModel
    {
        public IEnumerable<CarCrash> CarCrashes { get; set; }
        public int PreviousPageIndex { get; set; }
        public int CurrentPageIndex { get; set; }
    }

    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    
    public class Location
    {
        [JsonProperty("latitude")]
        public string Latitude { get; set; }

        [JsonProperty("longitude")]
        public string Longitude { get; set; }

        [JsonProperty("human_address")]
        public string HumanAddress { get; set; }
    }

    public class CarCrash
    {
        [JsonProperty("crash_date")]
        public DateTime CrashDate { get; set; }

        [JsonProperty("crash_time")]
        public string CrashTime { get; set; }

        [JsonProperty("on_street_name")]
        public string OnStreetName { get; set; }

        [JsonProperty("number_of_persons_injured")]
        public string NumberOfPersonsInjured { get; set; }

        [JsonProperty("number_of_persons_killed")]
        public string NumberOfPersonsKilled { get; set; }

        [JsonProperty("number_of_pedestrians_injured")]
        public string NumberOfPedestriansInjured { get; set; }

        [JsonProperty("number_of_pedestrians_killed")]
        public string NumberOfPedestriansKilled { get; set; }

        [JsonProperty("number_of_cyclist_injured")]
        public string NumberOfCyclistInjured { get; set; }

        [JsonProperty("number_of_cyclist_killed")]
        public string NumberOfCyclistKilled { get; set; }

        [JsonProperty("number_of_motorist_injured")]
        public string NumberOfMotoristInjured { get; set; }

        [JsonProperty("number_of_motorist_killed")]
        public string NumberOfMotoristKilled { get; set; }

        [JsonProperty("contributing_factor_vehicle_1")]
        public string ContributingFactorVehicle1 { get; set; }

        [JsonProperty("contributing_factor_vehicle_2")]
        public string ContributingFactorVehicle2 { get; set; }

        [JsonProperty("collision_id")]
        public string CollisionId { get; set; }

        [JsonProperty("vehicle_type_code1")]
        public string VehicleTypeCode1 { get; set; }

        [JsonProperty("vehicle_type_code2")]
        public string VehicleTypeCode2 { get; set; }

        [JsonProperty("borough")]
        public string Borough { get; set; }

        [JsonProperty("zip_code")]
        public string ZipCode { get; set; }

        [JsonProperty("latitude")]
        public string Latitude { get; set; }

        [JsonProperty("longitude")]
        public string Longitude { get; set; }

        [JsonProperty("location")]
        public Location Location { get; set; }

        [JsonProperty("cross_street_name")]
        public string CrossStreetName { get; set; }

        [JsonProperty("off_street_name")]
        public string OffStreetName { get; set; }

        [JsonProperty("contributing_factor_vehicle_3")]
        public string ContributingFactorVehicle3 { get; set; }

        [JsonProperty("contributing_factor_vehicle_4")]
        public string ContributingFactorVehicle4 { get; set; }

        [JsonProperty("vehicle_type_code_3")]
        public string VehicleTypeCode3 { get; set; }

        [JsonProperty("vehicle_type_code_4")]
        public string VehicleTypeCode4 { get; set; }

        [JsonProperty("contributing_factor_vehicle_5")]
        public string ContributingFactorVehicle5 { get; set; }

        [JsonProperty("vehicle_type_code_5")]
        public string VehicleTypeCode5 { get; set; }
    }
}

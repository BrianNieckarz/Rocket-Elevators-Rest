using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace RocketElevatorREST.Models
{
    public partial class Building
    {
        public Building()
        {
            Batteries = new HashSet<Battery>();
            BuildingDetails = new HashSet<BuildingDetail>();
        }

        public long Id { get; set; }
        public long? CustomerId { get; set; }
        public string? FullNameOfTheBuildingAdministrator { get; set; }
        public string? EmailOfTheAdministratorOfTheBuilding { get; set; }
        public string? PhoneNumberOfTheBuildingAdministrator { get; set; }
        public string? FullNameOfTheTechnicalContactForTheBuilding { get; set; }
        public string? TechnicalContactEmailForTheBuilding { get; set; }
        public string? TechnicalContactPhoneForTheBuilding { get; set; }
        [JsonIgnore]
        public DateTime CreatedAt { get; set; }
        [JsonIgnore]
        public DateTime UpdatedAt { get; set; }
        [JsonIgnore]
        public long? AddressId { get; set; }
        [JsonIgnore]

        [ForeignKey("AddressId")]
        public virtual Address? Address { get; set; }
        [JsonIgnore]

        [ForeignKey("CustomerId")]
        public virtual Customer? Customer { get; set; }
        [JsonIgnore]
        public virtual ICollection<Battery> Batteries { get; set; }
        [JsonIgnore]
        public virtual ICollection<BuildingDetail> BuildingDetails { get; set; }
    }

    public class BuildingDTO{
        public BuildingDTO()
        {
            Batteries = new HashSet<BatteryDTO>();
        }
        public long Id { get; set; }
        public virtual ICollection<BatteryDTO> Batteries { get; set; }
    }

}

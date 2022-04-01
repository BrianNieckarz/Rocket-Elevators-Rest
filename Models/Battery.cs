using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace RocketElevatorREST.Models
{
    public partial class Battery
    {
        public Battery()
        {
            Columns = new HashSet<Column>();
        }

        public long Id { get; set; }
        [JsonIgnore]
        public long? BuildingId { get; set; }
        public string? Status { get; set; }
        [JsonIgnore]
        public long? EmployeeId { get; set; }
        [JsonIgnore]
        public DateTime DateOfCommissioning { get; set; }
        [JsonIgnore]
        public DateTime DateOfLastInspection { get; set; }
        [JsonIgnore]
        public byte[]? CertificateOfOperations { get; set; }
        [JsonIgnore]
        public string? Information { get; set; }
        [JsonIgnore]
        public string? Notes { get; set; }
        [JsonIgnore]
        public DateTime CreatedAt { get; set; }
        [JsonIgnore]
        public DateTime UpdatedAt { get; set; }
        [JsonIgnore]
        public string? Typing { get; set; }
        [JsonIgnore]
        public virtual Building? Building { get; set; }
        [JsonIgnore]
        public virtual Employee? Employee { get; set; }
        [JsonIgnore]
        public virtual ICollection<Column> Columns { get; set; }
    }

    public class BatteryDTO{
        public BatteryDTO(){
            Columns = new HashSet<Column>();
        }
        public long Id { get; set; }
        public string? Status { get; set; } 
        public virtual ICollection<Column> Columns { get; set; }
    }
}

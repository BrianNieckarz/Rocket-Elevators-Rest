using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations.Schema;

namespace RocketElevatorsRestApi.Models
{
    public partial class Column
    {
        public Column()
        {
            Elevators = new HashSet<Elevator>();
        }

        public long Id { get; set; }
        [JsonIgnore]
        public long? BatteryId { get; set; }
        [JsonIgnore]
        public string? NumberOfFloorsServed { get; set; }
        public string? Status { get; set; }
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
        [ForeignKey("BatteryId")]
        public virtual Battery? Battery { get; set; }
        [JsonIgnore]
        public virtual ICollection<Elevator> Elevators { get; set; }
    }
}

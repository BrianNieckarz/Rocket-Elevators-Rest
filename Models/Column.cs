using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace RocketElevatorREST.Models
{
    public partial class Column
    {
        public Column()
        {
            Elevators = new HashSet<Elevator>();
        }

        public long Id { get; set; }
        public long? BatteryId { get; set; }
        public string? NumberOfFloorsServed { get; set; }
        public string? Status { get; set; }
        public string? Information { get; set; }
        public string? Notes { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string? Typing { get; set; }

        [ForeignKey("BatteryId")]
        public virtual Battery? Battery { get; set; }
        public virtual ICollection<Elevator> Elevators { get; set; }
    }
}

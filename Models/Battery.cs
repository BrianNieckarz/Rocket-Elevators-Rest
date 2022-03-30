using System;
using System.Collections.Generic;

namespace RocketElevatorREST.Models
{
    [System.ComponentModel.DataAnnotations.Schema.NotMapped] 
    public partial class Battery
    {
        public Battery()
        {
            Columns = new HashSet<Column>();
        }

        public long Id { get; set; }
        public long? BuildingId { get; set; }
        public string? Status { get; set; }
        public long? EmployeeId { get; set; }
        public DateTime DateOfCommissioning { get; set; }
        public DateTime DateOfLastInspection { get; set; }
        public byte[]? CertificateOfOperations { get; set; }
        public string? Information { get; set; }
        public string? Notes { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string? Typing { get; set; }

        public virtual Building? Building { get; set; }
        public virtual Employee? Employee { get; set; }
        public virtual ICollection<Column> Columns { get; set; }
    }
}

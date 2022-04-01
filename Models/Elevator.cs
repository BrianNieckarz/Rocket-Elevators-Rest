using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RocketElevatorsRestApi.Models {    
    public partial class Elevator {
        public long Id { get; set; }
        
        [JsonIgnore]
        public long? ColumnId { get; set; }
        [JsonIgnore]
        public string? SerialNumber { get; set; }
        [JsonIgnore]
        public string? Model { get; set; }
        public string? Status { get; set; }
        [JsonIgnore]
        public DateTime DateOfCommissioning { get; set; }
        [JsonIgnore]
        public DateTime DateOfLastInspection { get; set; }
        [JsonIgnore]
        public byte[]? CertificateOfInspection { get; set; }
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
        [ForeignKey("ColumnId")]
        public virtual Column? Column { get; set; }
    }
    public class ElevatorDto{
        public long Id { get; set; }
        public string? SerialNumber { get; set; }
        public string? Status { get; set; }
    }
    public class InvalidElevatorDto {
        public long Id { get; set; }        
        public long? ColumnId { get; set; }
        public string? SerialNumber { get; set; }
        public string? Model { get; set; }
        public string? Status { get; set; }      
    }
}

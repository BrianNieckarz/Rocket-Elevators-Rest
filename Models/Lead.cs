using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace RocketElevatorREST.Models
{
    public partial class Lead
    {
        public long Id { get; set; }
        public string? FullName { get; set; }
        public string? CompanyName { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? ProjectName { get; set; }
        public string? ProjectDescription { get; set; }
        public string? DepartmentInChargeOfElevators { get; set; }
        public string? Message { get; set; }

        [JsonIgnore]
        public byte[]? AttachedFileStoredAsBinary { get; set; }
        
        [JsonIgnore]
        public DateTime CreatedAt { get; set; }
        
        [JsonIgnore]
        public DateTime UpdatedAt { get; set; }
        public DateTime? DateOfContactRequest { get; set; }
    }
}

using System;
using System.Collections.Generic;

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
        public byte[]? AttachedFileStoredAsBinary { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateOnly? DateOfContactRequest { get; set; }
    }
}

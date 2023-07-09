using Microsoft.AspNetCore.Identity;

namespace LeaveManagement.web.Data
{
    public class Employee : IdentityUser
    {
        public string? Firstname { get; set; } //? Allow to be null
        public string? Lastname { get; set; }
        public string? TxtId { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime DateJoined { get; set;}
    }
}

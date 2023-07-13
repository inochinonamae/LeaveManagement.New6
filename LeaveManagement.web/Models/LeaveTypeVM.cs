using System.ComponentModel.DataAnnotations;

namespace LeaveManagement.web.Models
{
    public class LeaveTypeVM
    {
        public int Id { get; set; }

        [Display(Name = "Leave Type Name")]
        [Required]
        public string Name { get; set; }
        
        [Display(Name = "Default Number of days")]
        [Required]
        [Range(1, 25, ErrorMessage = "Please enter a valid number within 25 days")]
        public int DefaultDays { get; set; }
    }
}

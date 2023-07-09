using System.ComponentModel.DataAnnotations.Schema; //Optional, if use Data annotation

namespace LeaveManagement.web.Data
{
    public class LeaveAllocation : BaseEntity
    {
        public int NumberOfDays { get; set; }


        //Optional - Data annotation
        [ForeignKey("LeaveTypeId")]

        //Connect to LeaveType Table
                // Allows to get details and facilitates inner join much more easily
        public LeaveType LeaveType { get; set; }
        // The actual column that represent the foreigh key, right after the connection to the table
        public int LeaveTypeId { get; set; }
        
        //Referencing to EmployeeId
        public int EmployeeId { get; set; }

    }
}

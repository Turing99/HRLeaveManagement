using System.ComponentModel.DataAnnotations;

namespace HRLeaveManagement.Domain
{
    public class LeaveType
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string DefaultDays { get; set; }

        public DateTime DateCreated { get; set; }


    }
}
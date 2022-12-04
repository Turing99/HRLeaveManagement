using HRLeaveManagement.Application.DTOs.Common;

namespace HRLeaveManagement.Application.DTOs
{
    public class LeaveTypeDto : BaseDto
    {
        public string Name { get; set; }

        public string DefaultDays { get; set; }
    }
}

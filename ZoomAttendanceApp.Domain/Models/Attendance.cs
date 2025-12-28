using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZoomAttendanceApp.Domain.Models
{
    public class Attendance
    {
        public Student Student { get; set; }
        public string EntrDate { get; set; }
        public string ExitDate { get; set; }
        public int ParticipationMinutes { get; set; }
        public int WaitingMinutes { get; set; }
    }
}

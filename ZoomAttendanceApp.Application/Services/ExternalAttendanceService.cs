using WorkingWithFileExcel.Infrastucture.Data;
using ZoomAttendanceApp.Domain.Models;


namespace ZoomAttendanceApp.Application.Services
{
    public class ExternalAttendanceService
    {
        private readonly ExcelContext context;

        public ExternalAttendanceService()
        {
            context = new ExcelContext();
        }

        public List<ExternalAttendance> GetAll() => context.GetAll();

        public ExternalAttendance GetByName(string name)
        {
            return context.GetAll()
                .FirstOrDefault(x => x.FullNameWithCode.Contains(name, StringComparison.OrdinalIgnoreCase));
        }

        public ExternalAttendance GetByEmail(string email)
        {
            return context.GetAll()
                .FirstOrDefault(x => x.Email.Contains(email, StringComparison.OrdinalIgnoreCase));
        }

        public List<ExternalAttendance> GetGuests()
        {
            return context.GetAll().Where(x => x.IsHost == "Да").ToList();
        }

        public List<ExternalAttendance> GetWaitingRoom()
        {
            return context.GetAll().Where(x => x.IsWaiting == "Да").ToList();
        }

        public int GetCount()
        {
            return context.GetAll().Count();
        }

        public List<ExternalAttendance> GetMostActive()
        {
            return context.GetAll()
                .OrderByDescending(x => x.Duration)
                .Take(5)
                .ToList();
        }
    }
}

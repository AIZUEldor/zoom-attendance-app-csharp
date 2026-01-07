using ZoomAttendanceApp.Infrastructure.Data;
using ZoomAttendanceApp.Domain.Models;
using WorkingWithFileExcel.Infrastucture.Data;

namespace ZoomAttendanceApp.Application.Services
{
    public class StudentServise
    {
        private readonly ExcelContext context;
        private readonly List<ExternalAttendance> students;

        public StudentServise()
        {
            context = new ExcelContext();
            students = context.GetExternalAttendances();
        }

      
        public bool DeleteByName(string name)
        {
            var student = students.FirstOrDefault(s =>
                s.FullNameWithCode.Contains(name, StringComparison.OrdinalIgnoreCase));

            if (student == null)
                return false;

            students.Remove(student);
            return true;
        }

       
        public bool DeleteByCode(string code)
        {
            var student = students.FirstOrDefault(s =>
                s.FullNameWithCode.Contains(code, StringComparison.OrdinalIgnoreCase));

            if (student == null)
                return false;

            students.Remove(student);
            return true;
        }

        
        public void AddStudent(ExternalAttendance student)
        {
            students.Add(student);
        }

      
        public List<ExternalAttendance> GetAll()
        {
            return students;
        }
    }
}

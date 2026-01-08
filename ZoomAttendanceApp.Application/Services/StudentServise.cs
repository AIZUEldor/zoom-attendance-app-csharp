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
            
            int removedCount = students.RemoveAll(s =>
                s.FullNameWithCode.Contains(name, StringComparison.OrdinalIgnoreCase));

            
            return removedCount > 0;
        }

        public List<ExternalAttendance> GetByCode(string code)
        {
            return students
                .Where(s =>
                {
                    var parts = s.FullNameWithCode.Split(' ');
                    var studentCode = parts.Length > 0 ? parts[^1] : "";
                    return studentCode.Equals(code, StringComparison.OrdinalIgnoreCase);
                })
                .ToList();
        }





        public bool DeleteByCode(string code)
        {
            var student = students.RemoveAll(s =>
                s.FullNameWithCode.Contains(code, StringComparison.OrdinalIgnoreCase));

            return student > 0;
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

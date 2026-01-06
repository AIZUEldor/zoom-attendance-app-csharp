using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OfficeOpenXml;
using ZoomAttendanceApp.Domain.Models;
using ZoomAttendanceApp.Infrastructure.Data;

namespace ZoomAttendanceApp.Application.Services
{
    public class StudentServise
    {
       Student Student = new Student();
       public Student GetStudentFromExternalAttendance(ExternalAttendance externalAttendance)
       {
            var names = externalAttendance.FullNameWithCode.Split(' ');
            Student.FirstName = names[0];
            Student.LastName = names[1];
            Student.Code = names[2];
            Student.ExternalAttendance = externalAttendance;
            return Student;
       }



        

    }
}

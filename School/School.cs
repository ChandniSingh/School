using System;
using System.Collections.Generic;
using System.Text;

namespace School
{
   static class School
    {
        public  static Student CreateStudent (string Name,int Grade,TypeOfTransport Transport1=TypeOfTransport.Bus)
        {
            var student = new Student();

            student.StudentName = Name;
            student.StudentGrade = Grade;
            student.Transport = Transport1;

            return student;
        


        }

        public static Teacher CreateTeacher(String Name,decimal Salary)
        {
            var teacher = new Teacher();
            teacher.TeacherName1 = Name;
            teacher.Salary = Salary;
            return teacher;


        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace School
{
   static class School
    {
        private static List<Student> Students = new List<Student>();
        private static List<Teacher> Teachers = new List<Teacher>();
        private static int lastTeacherId = 0;
        private static int lastStudentId = 0;

        public  static Student CreateStudent (string Name,int Grade,TypeOfTransport Transport1=TypeOfTransport.Bus)
        {
            var student = new Student
            {
                StudentId = lastStudentId,
                StudentName = Name,
                StudentGrade = Grade,
                Transport = Transport1
            };

            Students.Add(student);
            ++lastStudentId;

            return student;
        }

        public static Teacher CreateTeacher(String Name,decimal Salary)
        {
            var teacher = new Teacher
            {
                TeacherName1 = Name,
                Salary = Salary
            };
            Teachers.Add(teacher);
            ++lastTeacherId;


            return teacher;
        }

        
        public static IEnumerable<Student> GetStudents()
        {
            return Students;
        }

        public static IEnumerable<Teacher> GetTeachers()
        {
            return Teachers;
        }
    }
}

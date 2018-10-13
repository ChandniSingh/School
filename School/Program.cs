using System;

namespace School
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            var Teacher1 = new Teacher("Col1")
            {
                TeacherId = 12,
                Salary = 190M,
                StartDate = DateTime.Now


            };



            //Instance of the class Student
            var Student1 = new Student("Singh")
           
            {
                //StudentId = 12345,
               // StudentName = "Singh",
               TeacherName = Teacher1,
                Transport = "Bus",
                Scores = 90,
                StudentGrade = 1
                
            };

            var Student2 = new Student("Singh2")
            {
               // StudentId = 12346,
                //StudentName = "Singh2",
                StudentGrade = 2,
                Transport = "Own",
                Scores = 80,
                TeacherName = Teacher1,
                Startdate = DateTime.Now


            };


    */

            /*
               Lesson 3

            var Student1 = School.CreateStudent("Singh1", 1,TypeOfTransport.Bus);
            var Student2 = School.CreateStudent("Singh2", 2);
            var teacher1 = School.CreateTeacher("Col1", 30000.00M);


           
            Console.WriteLine($"Student Name = {Student1.StudentName}, " +
                $"Id = {Student1.StudentId}," +
                $" Grade = {Student1.StudentGrade}," +
                $" Teacher = {teacher1.TeacherName1}," +
                $"Transport = {Student1.Transport}," +
                $" Start Date ={Student1.Startdate} ");

          
           Console.WriteLine($"Student Name = {Student2.StudentName}, " +
               $"Id = {Student2.StudentId}," +
               $" Grade = {Student2.StudentGrade}," +
               $" Teacher = {teacher1.TeacherName1}," +
               $"Transport = {Student2.Transport}," +
               $" Start Date ={Student2.Startdate} ");

    */

            ///Create a Menu for the Front Page
            ///

            Console.WriteLine("...........................");

            Console.WriteLine("Welcome to the School");
            Console.WriteLine("Select an option");
            Console.WriteLine("0. Exit");
            Console.WriteLine("1. New Student");
            Console.WriteLine("2. New Teacher");

            var option = Console.ReadLine();

            switch (option)
            {
                case "0":
                    return;
                case "1":
                    Console.Write("Enter Students Name: ");
                    var name = Console.ReadLine();

                    Console.Write("Enter Grade: ");
                    var grade = Console.ReadLine();

                    Console.WriteLine("Select Transport: ");

                    var Trans = Enum.GetNames(typeof(TypeOfTransport));

                    for (int i=0; i < Trans.Length; i++)
                    {
                        Console.WriteLine($"{i+ 1}. {Trans[i]}");
                    }

                    break;

                default:
                    break;
            }


        }
    }
}

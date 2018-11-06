using System;

namespace School
{
    class Program
    {
        static void Main(string[] args)
        {
             

            ///Create a Menu for the Front Page
            ///

            Console.WriteLine("...........................");

            Console.WriteLine("Welcome to the School");

            while (true)
            {
                Console.WriteLine("Select an option");
                Console.WriteLine("0. Exit");
                Console.WriteLine("1. New Student");
                Console.WriteLine("2. New Teacher");
                Console.WriteLine("3. Test Scores");
                Console.WriteLine("4. Leaves");
                Console.WriteLine("5. Print all Students");
                Console.WriteLine("6. Print all Teachers");

                var option = Console.ReadLine();

                switch (option)
                {
                    case "0":
                        return;
                    case "1":
                        Console.Write("Enter Students Name: ");
                        var name = Console.ReadLine();

                        Console.Write("Enter Grade: ");
                        var grade =Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Select Transport: ");

                        var Trans = Enum.GetNames(typeof(TypeOfTransport));

                        for (int i = 0; i < Trans.Length; i++)
                        {
                            Console.WriteLine($"{i + 1}. {Trans[i]}");
                        }

                        Console.Write("Enter Transport Type: ");
                        var readLine = Console.ReadLine();
                        var number = Convert.ToInt32(readLine);


                     var TransportType= Enum.Parse<TypeOfTransport>(Trans[number-1]);

                        var student = School.CreateStudent(name,grade,TransportType);

                        Console.WriteLine($"Student Name: {student.StudentName}, Grade: {student.StudentGrade}, Transport: {student.Transport}, Student id {student.StudentId} ");



                        break;

                    case "2":
                        Console.Write("Enter Teacher Name: ");
                        var Teachername = Console.ReadLine();

                        Console.Write("Enter Salary: ");
                        var  salary = Convert.ToDecimal(Console.ReadLine());

                        var teacher = School.CreateTeacher(Teachername,salary);

                        
                        Console.WriteLine($"Teacher Name: {teacher.TeacherName1}, Salary: {teacher.Salary}, Id:{teacher.TeacherId} ");
                        break;

                    case "3":
                        Console.WriteLine("Please try again.Still working on this option.");
                        break;

                    case "4":
                        Console.WriteLine("Please try again.Still working on this option.");

                    case "5":
                        {

                            var stud = School.GetStudents();

                            foreach (var s in stud)
                            {
                                Console.WriteLine($"Student Name: {s.StudentName}, Grade: {s.StudentGrade}, Transport: {s.Transport},Id: {s.StudentId}");
                            }
                            break;
                        }

                    case "6":
                        {
                            var tea = School.GetTeachers();
                            foreach (var t in tea)
                            {
                                Console.WriteLine($"Teacher Name: {t.TeacherName1}, TeacherId:{t.TeacherId},Salary: {t.Salary}");
                            }
                        }

                        break;

                    default:
                        break;
                }
            }


        }
    }
}

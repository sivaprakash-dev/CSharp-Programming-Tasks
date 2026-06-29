using System;
using System.Collections.Generic;


namespace Collections
{
    class Student_Management_System_Task
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Mark { get; set; }


        static List<Student_Management_System_Task> ss = new List<Student_Management_System_Task>();
        public void Addstudent()
        {
            Student_Management_System_Task s = new Student_Management_System_Task();

          
            try
            {
                Console.Write("Enter Your Id:");
                s.Id = int.Parse(Console.ReadLine());

                Console.Write("Enter Your Name:");
                s.Name =(Console.ReadLine());

                Console.Write("Enter Your Mark:");
                s.Mark = int.Parse(Console.ReadLine());

                ss.Add(s);


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void DisplayStudent()
        {
            if(ss.Count == 0)
            {
                Console.WriteLine("Student not Found");
                return;
            }
            foreach (var st in ss)
            {
                Console.WriteLine($"Id: {st.Id}, Name: {st.Name}, Mark: {st.Mark}");
            }

        }

        public void findStudentByid()
        {
            try
            {
                Console.WriteLine("Enter Your Id:");
                int id = int.Parse(Console.ReadLine());

                Student_Management_System_Task fo = ss.Find(s => s.Id == id);

                if (fo != null)
                {
                    Console.WriteLine($"Id: {fo.Id}, Name: {fo.Name}, Mark: {fo.Mark}");
                }
                else
                {
                    Console.WriteLine("Student not found");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

        public static void Main(string[] args)
        {
                
            while (true)
            {
                try
                {
                    Console.WriteLine("1.AddStudents");
                    Console.WriteLine("2.DisplayStudents");
                    Console.WriteLine("3.FindStudentById");
                    Console.WriteLine("4.Exit");
                    Console.WriteLine();
                    Console.WriteLine("Select Your Option:");
                    int option = int.Parse(Console.ReadLine());

                    Student_Management_System_Task ob = new Student_Management_System_Task();

                    switch (option)
                    {
                        case 1:

                            ob.Addstudent();
                            break;
                        case 2:
                            DisplayStudent();
                            break;
                        case 3:
                            ob.findStudentByid();
                            break;
                        case 4:
                            return;
                        default:
                            Console.WriteLine("Invalid Input");
                            break;

                    }
                } catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            
        }
    }
}

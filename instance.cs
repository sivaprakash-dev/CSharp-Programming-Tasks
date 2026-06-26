
using System;

class Student
{
    int marks = 80;   // Instance variable

    public void Display()
    {
        Console.WriteLine(marks);
    }
}

class instance
{
    static void Main()
    {
        Student s1 = new Student();
        Student s2 = new Student();

        s1.Display();   // 80
        s2.Display();   // 80



    }
}

using System;

class Program
{
    static void Main()
    {
        Sample sample = new Sample();
        Employee emp = new Employee() { Salary = 1000 };
        Student stu = new Student() { Marks = 80 };
        
        sample.PrintData<Employee>(emp);
        sample.PrintData<Student>(stu);

        Console.ReadKey();
    }
}
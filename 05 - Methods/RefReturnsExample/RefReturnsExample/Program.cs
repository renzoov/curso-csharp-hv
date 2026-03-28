class Student
{
    public int grade = 2;

    public void PrintGrade()
    {
        System.Console.WriteLine("Grade: " + grade);
    }

    public ref int DoWork()
    {
        return ref grade;
    }
}

class Program
{
    static void Main()
    {
        //creating object of Student
        Student s = new Student();
        
        //call PrintGrade
        s.PrintGrade();
        
        //call DoWork
        ref int g =  ref s.DoWork();

        //update the value of 'ref return'
        g = 5;
        
        //call PrintGrade after updating the value of 'ref return'
        s.PrintGrade(); //output: 5

        System.Console.ReadKey();
    }
}
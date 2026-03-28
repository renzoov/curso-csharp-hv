class Student
{
    public void DisplaySubjects(params string[] subjects)
    {
        for (int i = 0; i < subjects.Length; i++)
        {
            System.Console.WriteLine(subjects[i]);
        }
        
        //other form
        /*foreach (var subject in subjects)
        {
            System.Console.WriteLine(subject);
        }*/
    }
}

class Program
{
    static void Main()
    {
        Student s =  new Student();
        
        s.DisplaySubjects("Theory of Computation", "Computer Networks", "Discrete Mathematics", "Digital System Design");
    }
}
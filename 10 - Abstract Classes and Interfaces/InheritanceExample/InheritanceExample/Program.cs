class Program
{
    static void Main()
    {
        //create reference of parent interface (IEmployee)
        IEmployee emp;
        
        //create object of Manager
        emp = new Manager(102, "Allen", "New York", "Accounting");
        System.Console.WriteLine(emp.GetHealthInsuranceAmount());
        
        //IPerson
        IPerson person;
        person = new Manager(103, "John", "Washington", "East");
        person.DateOfBirth = System.Convert.ToDateTime("1990-07-16");
        System.Console.WriteLine(person.GetAge());
        System.Console.WriteLine();

        System.Console.ReadKey();
    }
}
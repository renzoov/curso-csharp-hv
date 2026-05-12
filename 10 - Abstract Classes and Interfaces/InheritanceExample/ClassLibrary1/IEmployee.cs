public interface IEmployee : IPerson
{
    //abstract method
    string GetHealthInsuranceAmount();
    int GetAge();
    
    //properties
   int EmpID { set; get; }
   string EmpName { set; get; }
   string Location { set; get; }
}
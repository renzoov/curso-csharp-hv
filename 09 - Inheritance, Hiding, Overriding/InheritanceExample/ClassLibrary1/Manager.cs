using System;

public class Manager : Employee
{
    //field
    private string _departmentName;
    
    //constructor of child class
    public Manager(int empID, string empName, string location, string departmentName) : base(empID, empName, location)
    {
        _departmentName = departmentName;
    }
    
    //property
    public string DepartmentName
    {
        set
        {
            _departmentName = value;
        }
        get
        {
            return _departmentName;
        }
    }
    
    //method
    public long GetTotalSalesOfTheYear()
    {
        return 1000;
    }
    
    //method
    public string GetFullDepartmentName()
    {
        return DepartmentName + " at " + base._location;
    }
    
    public sealed override string GetHealthInsuranceAmount()
    {
        Console.WriteLine(base.GetHealthInsuranceAmount());
        return "Additional Health Insurance Amount is: " + 1000;
    }
}

// las clases sealed no pueden ser heredadas
public class BranchManager : Manager
{
    public BranchManager(int empID, string empName, string location, string departmentName) : base(empID, empName, location, departmentName)
    {
        
    }

    //mehtod overriding virtual methods // not allowed
    /*public override string GetHealthInsuranceAmount()
    {
        
    }*/
}
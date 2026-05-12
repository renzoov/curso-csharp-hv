public class SalesMan : IEmployee
{
    //field
    private string _region;
    private int _empID;
    private string _empName;
    private string _location;
    private System.DateTime _dateOfBirth;

    public SalesMan(int empID, string empName, string location, string region) : base(empID, empName, location)
    {
        this._region = region;
    }
    
    //method overriding the abstract methods
    public string GetHealthInsuranceAmount()
    {
        return "Additional Health Insurance premium amount is: 1000";
    }

    int IEmployee.GetAge()
    {
        throw new System.NotImplementedException();
    }

    //property
    public string Region
    {
        set
        {
            _region = value;
        }
        get
        {
            return _region;
        }
    }
    
    public int EmpID
    {
        set
        {
            if (value >= 1000 && value <= 2000)
            {
                _empID = value;
            }
        }
        get { return _empID; }
    }

    public string EmpName
    {
        set { _empName = value; }
        get { return _empName; }
    }

    public string Location
    {
        set { _location = value; }
        get { return _location; }
    }
    
    public System.DateTime DateOfBirth
    {
        set { _dateOfBirth = value; }
        get { return _dateOfBirth; }
    }

    int IPerson.GetAge()
    {
        throw new System.NotImplementedException();
    }

    //method
    public long GetSalesOfTheCurrentMonth()
    {
        return 1000;
    }
}
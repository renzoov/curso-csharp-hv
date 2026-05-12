using m = HR.Mgr;
using FrontOffice;

class Program
{
    static void Main()
    {
        m.IManager manager1;
        manager1 = new m.Manager();
        
        m.IManager manager2;
        manager2 = new m.Manager();
        
        m.IManager manager3;
        manager3 = new m.Manager();
        
        CustomerEnquiry customerEnquiry = new CustomerEnquiry();

        System.Console.ReadKey();
    }
}
using System;

namespace global
{
interface GovtRules
{
  public double EmployeePF(double baseSalary);
  public string LeaveDetails();
  public double GratuityAmount(float Service, double baseSalary);
}

public class TCS: GovtRules
{
    public int empID;
    public string name;
    public string dept;
    public string desg;
    public double baseSalary;
    public TCS(int empId,string name,string dept,string desg,double baseSalary)
    {
        this.empID = empID;
        this.name= name;
        this.dept = dept;
        this.desg = desg;
        this.baseSalary = baseSalary;
    }

    public double EmployeePF(double baseSalary)
    {
      return (baseSalary*12)/100;
    }

    public string LeaveDetails()
    {

      return ("Casual leave of 1 day per month" + "\n" + "Sick Leave is 12 per year" + "\n" + "Privilage Leave of 10 days per year");
    }

    public double GratuityAmount(float Service,double baseSalary)
    {
      double gratuity = 0.0;
      if (Service>20)
      {
        gratuity = 3*baseSalary;
      }
      else if (Service > 10)
      {
        gratuity = 2*baseSalary;
      }
      else if (Service > 5)
      {
        gratuity = baseSalary;
      }
      return gratuity;
    }
}

public class WellsFargo: GovtRules
{
    public int empID;
    public string name;
    public string dept;
    public string desg;
    public double baseSalary;
    public WellsFargo(int empId,string name,string dept,string desg,double baseSalary)
    {
        this.empID = empID;
        this.name= name;
        this.dept = dept;
        this.desg = desg;
        this.baseSalary = baseSalary;
    }

    public double EmployeePF(double baseSalary)
    {
      return (baseSalary*12)/100;
    }

    public string LeaveDetails()
    {

      return ("Casual leave of 2 day per month" + "\n" + "Sick Leave is 5 per year" + "\n" + "Privilage Leave of 5 days per year");
    }

    public double GratuityAmount(float Service,double baseSalary)
    {
      double gratuity = 0.0;
      return gratuity;
    }
}
    public class Test
    {
      public static void Main()
      {
        var obj2 = new TCS(1002,"raja","Software","System Engineer",500000);
        Console.WriteLine(obj2.LeaveDetails());
        Console.WriteLine(obj2.EmployeePF(obj2.baseSalary));
        Console.WriteLine(obj2.GratuityAmount(12,obj2.baseSalary));

        var obj1 = new WellsFargo(2101,"Tribhu","Software","Associate",800000);
        Console.WriteLine(obj1.LeaveDetails());
        Console.WriteLine(obj1.EmployeePF(obj1.baseSalary));
        Console.WriteLine(obj1.GratuityAmount(5,obj1.baseSalary));
      }
    }
}


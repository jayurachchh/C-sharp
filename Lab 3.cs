using System;
using System.Diagnostics;
using System.Xml.Linq;

class Lab3
{
    public static void Main()                    
    {
        Candidate c = new Candidate();
        c.GetCandidateDetails();
        c.DisplayCandidateDetails();

        Staff[] s = new Staff[5];
        int i;
        for (i = 0; i < s.Length; i++)
        {
            s[i] = new Staff();
            s[i].GetCandidateDetails();

        }
        for (i = 0; i < s.GetLength(0); i++)
        {
            s[i].DisplayCandidateDetails();
        }

        Bank_Account b = new Bank_Account();
        b.GetAccountDetails();
        b.DisplayAccountDetails();

        Student s = new Student();
        s.DisplayStudentDetails();

        Salary salary = new Salary();
        salary.DisplayDetails();

        Distance d = new Distance();
        d.Display();

        Area a = new Area();
        Table table = new Table();
        table.get();
        table.get1();
        table.display();
        table.display1();

        Interest i = new Interest();
        i.getdetails();
        i.Calculate();
        i.Display();

        Employee employee = new Employee();
        employee.Disp_sal();
        employee.Gross_sal();
        employee.basic_sal();
    }
}


//10
 public interface Gross 
{
    public void Gross_sal();
}
public class Salary1 : Gross
{
     double HRA;
    double TA;
    double DA;
    public double total;
    public void Gross_sal()
    {
        total=HRA+TA+DA;
        Console.WriteLine("Salary is {0}", total);
    }

    public void Disp_sal() 
    {

        Console.WriteLine("Enter the HRA");
        HRA = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the TA");
        TA = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the DA");
        DA = Convert.ToDouble(Console.ReadLine());
    }

}
public class Employee :Salary1
{
    String Name;
    double basic_salary;
    double gross;
    public void basic_sal()
    {
        Console.WriteLine("Enter the name");
        Name = Console.ReadLine();

        Console.WriteLine("Enter the basic_salary");
        basic_salary = Convert.ToDouble(Console.ReadLine());

        gross = total + basic_salary;
        Console.WriteLine("gross Salary is {0}",gross);
    }
}

//9.
public class Account_Details
{
   public  double p;
    public double r;
    public double n;
    public void getdetails()
    {

        Console.WriteLine("Enter the p");
        p = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the rate");
        r = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the n");
        n = Convert.ToDouble(Console.ReadLine());
    }
}
public class Interest:Account_Details
{
    double Inr;
    public void Calculate()
    {
        Inr = (p * r * n)/100;
    }
    public void Display()
    {
        Console.WriteLine("Interest is {0}",Inr);
    }
}

//8.
public class Furniture
{
    String material;
    double price;
    public void get() 
    {
        Console.WriteLine("Enter the material");
        material = Console.ReadLine();

        Console.WriteLine("Enter the price");
        price = Convert.ToDouble(Console.ReadLine());
    }
    public void display()
    {
        Console.WriteLine("material is {0}", material);
        Console.WriteLine("price is {0}", price);
    }
}
public class Table : Furniture
{
    double Height;
    double surface_area;
    public void get1()
    {
        Console.WriteLine("Enter the Height");
        Height = Convert.ToDouble( Console.ReadLine());

        Console.WriteLine("Enter the surface_area");
        surface_area = Convert.ToDouble(Console.ReadLine());
    }
    public void display1()
    {
        Console.WriteLine("Height is {0}", Height);
        Console.WriteLine("surface_area {0}", surface_area);
    }
}

//7.
public class Area
{
    double length;
    double width;
    double area;
    public Area() 
    {
        Console.WriteLine("Enter the length");
        length=Convert.ToDouble( Console.ReadLine());

        Console.WriteLine("Enter the width");
        width = Convert.ToDouble(Console.ReadLine());

        area=length*width;
        Console.WriteLine("Area is {0}", area);

    }
}

//6.
public class Distance
{
    int dist1;
    int dist2;
    int dist3;  
    public Distance()
    {
        dist1 = 20;
        dist2 = 30;
    }
    public void Display()
    {
        dist3=dist1 + dist2;
        Console.WriteLine("Addtion is {0}", dist3);
    }
}

//5.
public class Salary
{
     double TA;
     double DA;
     double HRA;
     double total;

    public Salary()
    {
        Console.WriteLine("Enter the ");
        TA = Convert.ToDouble(Console.ReadLine());
        DA = 15;
        HRA = 23;
        total = TA + DA + HRA;
    }
   
    public void DisplayDetails()
    {
        Console.WriteLine("Salary is {0}", total);
       
    }
}

//4.
public class Student
{
    int Enrollment_No;
    String Student_Name;
    String Semester;
    double CPI;
    double SPI;

    public Student()
    {
        Console.WriteLine("Enter the Enrollment_No");
        Enrollment_No = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the Student_Name");
        Student_Name = Console.ReadLine();

        Console.WriteLine("Enter the Semester");
        Semester = Console.ReadLine();

        Console.WriteLine("Enter the CPI");
        CPI = Convert.ToDouble( Console.ReadLine());

        Console.WriteLine("Enter the SPI");
        SPI = Convert.ToDouble(Console.ReadLine());
    }
    public void DisplayStudentDetails()
    {
        Console.WriteLine("Enrollment_No is {0}", Enrollment_No);
        Console.WriteLine("Student_Name is {0}", Student_Name);
        Console.WriteLine("Semester  is {0}", Semester);
        Console.WriteLine("CPI is {0}", CPI);
        Console.WriteLine("SPI is {0}", SPI);
    }
}

//3.
public class Bank_Account
{
    int Account_No;
    String Email;
    String User_Name;
    String Account_Type;
    double Account_Balance;

   public void GetAccountDetails()
    {
        Console.WriteLine("Enter the Account_No");
        Account_No = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the Email");
        Email = Console.ReadLine();

        Console.WriteLine("Enter the User_Name");
        User_Name = Console.ReadLine();

        Console.WriteLine("Enter the Account_Type");
        Account_Type =Console.ReadLine();

        Console.WriteLine("Enter the Account_Balance");
        Account_Balance = Convert.ToDouble(Console.ReadLine());
    }

    public void DisplayAccountDetails()
    {
        Console.WriteLine("Account_No is {0}", Account_No);
        Console.WriteLine("Email is {0}", Email);
        Console.WriteLine("User_Name  is {0}", User_Name);
        Console.WriteLine("Account_Type is {0}", Account_Type);
        Console.WriteLine("Account_Balance is {0}", Account_Balance);
    }
}

//2.
public class Staff
{
    String Name;
    String Department;
    String Designation;
    String Experience;
    int Salary;


  
          public void GetCandidateDetails()
    {
            Console.WriteLine("Enter the Staff name");
            Name = Console.ReadLine();

            Console.WriteLine("Enter the Department");
            Department = Console.ReadLine();

            Console.WriteLine("Enter the Designation");
            Designation = Console.ReadLine();

            Console.WriteLine("Enter the Experience");
            Experience = Console.ReadLine();

            Console.WriteLine("Enter the Salary");
            Salary = Convert.ToInt32(Console.ReadLine());
        }
        
    

    public void DisplayCandidateDetails()
    {
        if(Designation =="HOD".ToLower())
        {
            Console.WriteLine("Name is {0}", Name);
           // Console.WriteLine("Department is {0}", Department);
            //Console.WriteLine("Designation  is {0}", Designation);
            //Console.WriteLine("Experience is {0}", Experience);
            Console.WriteLine("Salary is {0}", Salary);
        }
       
    }



}

// 1.
public class Candidate
{
    int id;
    String name;
    int Age;
    int height;
    int weight;

   public  void GetCandidateDetails()
    {
        Console.WriteLine("Enter the id");
        id = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the name");
        name = Console.ReadLine();

        Console.WriteLine("Enter the Age");
        Age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the Height");
       height = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the Weight");
        weight = Convert.ToInt32(Console.ReadLine());
    }

    public void DisplayCandidateDetails()
    {
        Console.WriteLine("Id is {0}", id);
        Console.WriteLine("Name is {0}", name);
        Console.WriteLine("Age  is {0}", Age);
        Console.WriteLine("Height is {0}", height);
        Console.WriteLine("Wight is {0}", weight);
    }



}


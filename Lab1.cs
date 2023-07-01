
using System;
public class Lab1
{
    public static void Main()
    {
        //odd();
        //Max();
        //Foc();
        //Area();
        //meter();
        //Prime();

        Info info = new Info();
        info.Dispaly();

        Num num = new Num();
        num.Display();

        Country country = new Country();
        country.Dispaly();

        Rect r = new Rect();
        r.Dispaly();

        Area area = new Area();
        area.Circle();
        area.Square();
        area.Triangle();

        Cel c = new Cel();
        c.Foc();
        c.Cof();

        Account_Details a = new Account_Details();
        a.getdetails();

        Cal cal = new Cal();
        cal.swich();
        cal.ifelse();

        Max m = new Max();
        m.Maxofthree();

        Swap s = new Swap();
        s.swap();
    }


    /*public static void odd()
    {
        string a;
        int num;

        Console.WriteLine("Enter the Number");
        a = Console.ReadLine();


        num = Convert.ToInt32(a);

        Console.WriteLine("number is {0}", num);
        if (num % 2 == 0)
        {
            Console.WriteLine("number even {0}", num);
        }
        else
        {
            Console.WriteLine("number odd {0}", num);
        }

    }
    public static void Max()
    {
        string a;
        string b;
        string c;
        int Max2;
        int Max1;
        int Max;

        Console.WriteLine("Enter the Number a");
        a = Console.ReadLine();

        Console.WriteLine("Enter the Number b");
        b = Console.ReadLine();

        Console.WriteLine("Enter the Number c");
        c = Console.ReadLine();

        Max = Convert.ToInt32(a);
        Max1 = Convert.ToInt32(b);
        Max2 = Convert.ToInt32(c);

        Console.WriteLine("number is {0}", Max);
        Console.WriteLine("number is {0}", Max1);
        Console.WriteLine("number is {0}", Max2);

        if (Max > Max1 && Max > Max2)
        {
            Console.WriteLine("Max is {0}", Max);
        }
        else if (Max1 > Max2)
        {
            Console.WriteLine("Max is {0}", Max1);
        }
        else
        {
            Console.WriteLine("Max is {0}", Max2);
        }
    }
    public static void Foc()
    {
        string a;
        double Fahrenheit;
        double celsius;


        Console.WriteLine("Enter the Fahrenheit");
        a = Console.ReadLine();

        Fahrenheit = Convert.ToInt32(a);
        celsius = (Fahrenheit - 32 / 1.8);

        Console.WriteLine("number is {0}", celsius);

    }
    public static void Area()
    {
        string a;
        double Radius;
        double Aor;
        double pie = 3.14;

        Console.WriteLine("Enter the Number a");
        a = Console.ReadLine();

        Radius = Convert.ToInt32(a);

        Console.WriteLine("number is {0}", Radius);
        Aor = pie * Radius * Radius;
        Console.WriteLine("number is {0}", Aor);
    }
    public static void meter()
    {
        string a;
        double meter;
        double feet;


        Console.WriteLine("Enter the Number a");
        a = Console.ReadLine();

        meter = Convert.ToInt32(a);

        feet = meter * 3.28084;

        Console.WriteLine("number is {0}", feet);

    }
    public static void Prime()
    {
        string a;
        int Prime;
        int Counter = 0;
        Console.WriteLine("Enter the Number a");
        a = Console.ReadLine();

        Prime = Convert.ToInt32(a);

        Console.WriteLine("number is {0}", Prime);
        if (Prime % 2 == 0)
        {
            Counter++;
        }
        if (Counter == 0)
        {
            Console.WriteLine("Number is Prime");
        }
        else
        {
            Console.WriteLine("Number is not Prime");
        }
    }*/
}
//10.
public class Swap
{
    public void swap()
    {
        double num1;
        double num2;
       
        Console.WriteLine("Enter the Number 1");
        num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the Number 2");
        num2 = double.Parse(Console.ReadLine());

        num1 = num1 + num2;
        num2 = num1 - num2;
        num1 = num1 - num2;
        Console.WriteLine("number 1 is {0} ",num1 + "number 2 is "+num2);
    }
}

//9.
public class Max
{
    public void Maxofthree()
    {
        string a;
        string b;
        string c;
        int Max2;
        int Max1;
        int Max;

        Console.WriteLine("Enter the Number a");
        a = Console.ReadLine();

        Console.WriteLine("Enter the Number b");
        b = Console.ReadLine();

        Console.WriteLine("Enter the Number c");
        c = Console.ReadLine();

        Max = Convert.ToInt32(a);
        Max1 = Convert.ToInt32(b);
        Max2 = Convert.ToInt32(c);

      /*  Console.WriteLine("number is {0}", Max);
        Console.WriteLine("number is {0}", Max1);
        Console.WriteLine("number is {0}", Max2);*/

        if (Max > Max1 && Max > Max2)
        {
            Console.WriteLine("Max is {0}", Max);
        }
        else if (Max1 > Max2)
        {
            Console.WriteLine("Max is {0}", Max1);
        }
        else
        {
            Console.WriteLine("Max is {0}", Max2);
        }
    }
}

//8.
public class Cal
{
    public void swich()
    {
       
        Console.WriteLine("Using SWITCH CASE");
        double num;
        double num1;
        int Choice;
        double Add;
        double Sub;
        double Mul;
        double div;

        Console.WriteLine("Enter the Number 1");
        num = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the Number 2");
        num1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the Choice");
        Console.WriteLine("1.Addition /n 2.Subtraction /n 3.Multipleaction /n 4.Division");


        
        Choice = Convert.ToInt32(Console.ReadLine());



        switch (Choice)
        {
            case 1:
                Add = num + num1;
                Console.WriteLine("Addition {0}", Add);
                break;
            case 2:
                Sub = num - num1;
                Console.WriteLine("Addition {0}", Sub);
                break;
            case 3:
                Mul = num * num1;
                Console.WriteLine("Addition {0}", Mul);
                break;
            case 4:
                div = num / num1;
                Console.WriteLine("Addition {0}", div);
                break;

            default:
                Console.WriteLine("Invalid case");
                break;
        }
    }
    public void ifelse()
    {
        Console.WriteLine("Using IF ELSE");
        double num;
        double num1;
        int Choice;
        double Add;
        double Sub;
        double Mul;
        double div;

        Console.WriteLine("Enter the Number 1");
        num = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the Number 2");
        num1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the Choice");
        Console.WriteLine("1.Addition /n 2.Subtraction /n 3.Multipleaction /n 4.Division");

        Choice = Convert.ToInt32(Console.ReadLine());

        if(Choice == 1) 
        {
            Add = num + num1;
            Console.WriteLine("Addition {0}", Add);
        }
        else if(Choice == 2) 
        {
            Sub = num - num1;
            Console.WriteLine("Addition {0}", Sub);
        }
        else if(Choice == 3) 
        {
            Mul = num * num1;
            Console.WriteLine("Addition {0}", Mul);
        }
        else if(Choice == 4) 
        {
            div = num / num1;
            Console.WriteLine("Addition {0}", div);
        }
        else  
        {
            Console.WriteLine("Invalid case");
        }
    }

}

//7.
public class Account_Details
{
    public double p;
    public double r;
    public double n;
    double Inr;
    public void getdetails()
    {

        Console.WriteLine("Enter the p");
        p = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the rate");
        r = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the n");
        n = Convert.ToDouble(Console.ReadLine());


        Inr = (p * r * n) / 100;
        Console.WriteLine("Interest is {0}", Inr);
    }
}

//6.
public class Cel
{
    public void Foc()
    {
        string a;
        double Fahrenheit;
        double celsius;


        Console.WriteLine("Enter the Fahrenheit");
        a = Console.ReadLine();

        Fahrenheit = Convert.ToInt32(a);
        celsius = (Fahrenheit - 32 / 1.8);

        Console.WriteLine("number is {0}", celsius);

    }

    public void Cof()
    {
        string a;
        double Fahrenheit;
        double celsius;


        Console.WriteLine("Enter the Fahrenheit");
        a = Console.ReadLine();

        celsius = Convert.ToDouble(a);
        Fahrenheit = (celsius * 1.8000) + 32;

        Console.WriteLine("number is {0}", Fahrenheit);

    }
}

//5.
public class Area 
{
    public double r;
    public double pi = 3.14;
    public double aoc;
    public double b;
    public double h;
    public double aot;
    public double a;
    public double aos;
    public void Circle()
    {
        Console.WriteLine("Area of Circle");

        Console.WriteLine("Enter the Radius");
        r = Convert.ToDouble(Console.ReadLine());

        aoc = pi * r * r;
        Console.WriteLine("Area of Circle is {0} ", aoc);
    }
    public void Triangle()
    {
        Console.WriteLine("Area of Triangle");
        Console.WriteLine("Enter the base");
        b = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the height");
        h = Convert.ToDouble(Console.ReadLine());

        aot = (b * h) / 1 / 2;
        Console.WriteLine("Area of Triangle is {0}", aot);
    }
    public void Square()
    {
        Console.WriteLine("Area of Square ");
        Console.WriteLine("Enter the a");
        a = Convert.ToDouble(Console.ReadLine());

        aos = a * a;
        Console.WriteLine("Area of Square is {0}", aos);
    }
}

//4.
public class Rect
{
    double b;
    double h;
    double aor;
    public void Dispaly()
    {
        Console.WriteLine("Area of Rectangle");
        Console.WriteLine("Enter the base");
        b = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the height");
        h = Convert.ToDouble(Console.ReadLine());

        aor = h*b;
        Console.WriteLine("Area of Rectangle is {0}", aor);
    }
}

//3
public class Country
{
    String name;
    String country;
    public void Dispaly()
    {
        Console.WriteLine("Enter the name");
        name = Console.ReadLine();

        Console.WriteLine("Enter the city");
        country = Console.ReadLine();

        Console.WriteLine("Hello {0}",name+" From countrty "+country);
       
    }
}

//2.
public class Num
{
    int a;
    int b;
    public void Display()
    {
        Console.WriteLine("Enter the Number 1");
        a= Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the Number 2");
        b = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Number is {0}",a);
        Console.WriteLine("Number is {0}",b);

    }
}

//1.
public class Info
    {
        String name;
        String Address;
        int Contactno;
        String City;
        public void Dispaly()
        {
            Console.WriteLine("Enter the name");
            name = Console.ReadLine();

            Console.WriteLine("Enter the Address");
            Address= Console.ReadLine();

            Console.WriteLine("Enter the Number");
            Contactno = Convert.ToInt32 (Console.ReadLine());

            Console.WriteLine("Enter the city");
            City = Console.ReadLine();

            Console.WriteLine("Name is {0}",name);
            Console.WriteLine("Address is {0}",Address);
            Console.WriteLine("Contactno is {0}", Contactno);
            Console.WriteLine("City is {0}",City);
        }
    }

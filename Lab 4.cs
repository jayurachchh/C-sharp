using System;

class Lab4
{
    public static void Main()
    {
        Divide s = new Divide();
        s.dis();

        Range range = new Range();
        range.dis1();

        Thro thro = new Thro();
        thro.odd();

        Calculate c = new Calculate();
        c.SumOfTwo(10, 20);
        c.SumOfThree(10, 20, 30);

        Result result = new Result();
        result.Addition();
        result.Subtraction();

        Area area = new Area();
        area.Circle();
        area.Square();
        area.Triangle();

        Case c2 = new Case();
        c2.display();

        Common c1 = new Common();
        c1.display1();

    }

}
//10.

//9.

//8.
public class Case
{
    String a = "Jay Rachchh";
    public void display() 
    {
        Console.WriteLine("Lower case is {0}",a.ToLower());
        Console.WriteLine("Upper case is {0}",a.ToUpper());
        Console.WriteLine("Original String is {0}",a);
    }
}


//7.
public class Common
{
    String a = "Jay Rachchh";
    String d = "Jay Rachchh";
    public String b = "Jay";
    public String c = "Rachchh";
    public String join;
    public Boolean result1;
    public Boolean result2;
    public void display1() 
    {
        Console.WriteLine("Length is {0}", a.Length);

        join=string.Concat(b,c);
        Console.WriteLine("join is {0}",join);

        result1  =a.Equals(b);
        result2 = a.Equals(d);

        Console.WriteLine("Equal is {0}", result1);
        Console.WriteLine("Equal is {0}", result2);

    }
}

//6.
interface Shape
{
    public void Circle() { }
    public void Triangle() { }
    public void Square(){ }
}
public class Area : Shape
{
   public  double r;
    public double pi=3.14;
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
        r=Convert.ToDouble(Console.ReadLine());

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

        aot = (b * h)/1/2;
        Console.WriteLine("Area of Triangle is {0}", aot);
    }
    public void Square() 
    {
        Console.WriteLine("Area of Square ");
        Console.WriteLine("Enter the a");
        a = Convert.ToDouble(Console.ReadLine());

        aos = a*a;
        Console.WriteLine("Area of Square is {0}", aos);
    }
}

//5.
interface Calculate
{
    public void Addition()
    { }
    public void Subtraction() { }
}
public class Result :Calculate
{
    public double a;
    public double b;
    public double Add;
    public double Sub;

    public void Addition() 
    {
        Console.WriteLine("Enter the number 1");
        a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter the number 2");
        b = Convert.ToDouble(Console.ReadLine());
        Add = a + b;
    }
    public void Subtraction() 
    {
        Sub = a - b;
        Console.WriteLine("Addtion is {0}",Add);
        Console.WriteLine("Subtractioin is {0}",Sub);

    }
}


//4.
public class Calculate
{
    int sum;
    int sum1;
    public void SumofTwo(int a, int b)
    {
        sum = a + b;
    }
    public void SumOfThree(int a, int b,, int c)
    {
        sum1 = a + b + c;
    }
}
abstract public class Sum:Calculate
{
    abstract public void SumOfTwo(int a, int b);
    abstract public void SumOfThree(int a, int b ,int c);
}

//3.
public class Thro
{
    public void odd()
    {
        string a;
        int num;
        try
        {
            Console.WriteLine("Enter the Number");
            a = Console.ReadLine();


            num = Convert.ToInt32(a);

           
            if (num % 2 == 0)
            {
                Console.WriteLine("number even {0}", num);
            }
            else
            {
                throw new Exception("Number is not even!");
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.ToString());
        }
       
    }
}

// 2.
public class Range
{
    int[] a= {2,5,6,8,9};
    public void dis1()
    {
        try
        {
            Console.WriteLine("Array is {0}", a[5]);
        }
        catch(IndexOutOfRangeException e) 
        {
            Console.Write(e);
        }
        catch (Exception e)
        {
            Console.Write(e.Message);
        }
    }
}

// 1.
public class Divide
{
    int a;
    int b;
    int c;
    public void dis()
    {
        
        try
        {
            Console.WriteLine("Enter the number 1");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number 2");
            b = Convert.ToInt32(Console.ReadLine());

            c = a / b;
            Console.WriteLine("value is", c);
        }
        catch(DivideByZeroException e) 
        {
            Console.Write(e);
        }
        catch (Exception e) {
            Console.Write(e.Message);
        }
    }
}

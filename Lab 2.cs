
using System;

public class Lab2
{
    public static void Main()
    {
        //Cal();
        // Bmi();
        //Fact();
        //Area();
        //Marks();
        //Leap();
        //Binary();
        // Pattern(); 
        //Fibbo();

        BMI b = new BMI();
        b.Bmi();

        Cal1 c = new Cal1();
        c.swich();
        c.ifelse();

        Prime p = new Prime();
        p.Prim();

        Year y = new Year();
        y.Leap();

        Fibbo f = new Fibbo();
        f.Fiboseries();

        BinaryForm bin = new BinaryForm();
        bin.Binary();



    }
   /* public static void Cal()  
    {
        String c;
        double num;
        double  num1;
        int Choice;
        double Add;
        double Sub;
        double Mul;
        double div;

        Console.WriteLine("Enter the Number 1");
        num =Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the Number 2");
        num1 = double.Parse(Console.ReadLine());

        Console.WriteLine("number is {0}", num);
        Console.WriteLine("number is {0}", num1);


        Console.WriteLine("1.Addition /n 2.Subtraction /n 3.Multipleaction /n 4.Division");

        Console.WriteLine("Enter the Choice");
        Choice= Convert.ToInt32(Console.ReadLine());


        
        switch(Choice)
        {
            case 1: Add = num + num1;
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

            case 5:
            
                    Console.WriteLine("Invalid case");
                    break;
        }
    }

    public static void Bmi()
        
    {
        double num;
        double num1;
        double height;
        double weight;
        double BMi;

        Console.WriteLine("Enter the Weight into pound");
        num = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the height into inches");
        num1 = double.Parse(Console.ReadLine());

        weight = num * 0.45359237;
        height = num1 * 0.0254;
        BMi = weight / height;

        Console.WriteLine("BMI is {0}", BMi);



    }

    public static void Fact()
    {
        int num;
        int fact = 1;
        Console.WriteLine("Enter the Number 1");
        num = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= num; i++)
        {
            fact = fact * i; 
        }
        Console.WriteLine("FActorial is {0}", fact);
    }

    public static void Area()
        {
            string a;
            double Aor;
            double pie = 3.14;
            double Diameter;
            double Radius;
            double rem;
            Console.WriteLine("Enter the Number a");
            a = Console.ReadLine();

            Aor = Convert.ToDouble(a);

            Console.WriteLine("number is {0}", Aor);

            rem = Aor / pie;
            Radius = Math.Sqrt(rem);
            Diameter = 2 * Radius;
            Console.WriteLine("Diameter is {0}", Diameter);
        }

    public static void Marks()
    {
        double num1;
        double num2;
        double num3;
        double num4;
        double num5;

        Console.WriteLine("Enter the Number 1");
        num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the Number 2");
        num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the Number 3");
        num3 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the Number 4");
        num4 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the Number 5");
        num5 = Convert.ToDouble(Console.ReadLine());

        double add = num1 + num2 + num3 + num4 + num5; ;
        double avg = add / 5;
        double per = (add * 100) / 500;

        if (per <= 40)
        {
            Console.WriteLine("You are the Fali because of you got the {0}",per+"%");
        }
        else if (per > 41 && per <= 49)
        {
           Console.WriteLine("You are the third Class because of you got the {0}", per + "%");
        }
        else if (per > 50 && per <= 59)
        {
            Console.WriteLine("You are the Second Class Pass because of you got the {0}", per + "%");
        }
        else
        {
            Console.WriteLine("You are the First Class Pass because of you got the {0}", per + "%");
        }
    }

    public static void Binary()
    {
        int num;
        string result;

        Console.Write("Input a Number : ");
        num = Convert.ToInt32(Console.ReadLine());

        result = "";
        while (num > 1)
        {
            int remainder = num % 2;
            result = Convert.ToString(remainder) + result;
            num /= 2;
        }
        result = Convert.ToString(num) + result;
        Console.WriteLine("Binary: {0}", result);
    }

    public static void Leap()
    {
        int a;
        Console.WriteLine("Enter the Number 1");
        a = Convert.ToInt32(Console.ReadLine());

        if ((a % 4 == 0 && a% 100 != 0) || a% 400 == 0)
        {
            Console.WriteLine("This Year Is Leap year ", a);
        }
        else
        {
            Console.WriteLine("This Year Is not Leap year ", a);
        }

    }

    public static void Pattern()
    {
        int i, j, k;
        for (i = 1; i <= 5; i++)
        {
            for (j = 5; j >= i; j--)
            {
                Console.WriteLine(" ");
            }
            for (k = 1; k <= i; k++)
            {
                Console.WriteLine("*");
            }
           // Console.WriteLine(" ");
        }
    }

    public static void Fibbo()
    {
        int num;
        int temp;
        int k = 0;
        int j = 1;

        Console.WriteLine("Enter the number ");
        num = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < num; i++)
        {
            Console.WriteLine(k);
            temp = k + j;
            k = j;
            j = temp;
        }

    }*/
}

//7.

//6.
public class BinaryForm
{
    public void Binary()
    {
        int num;
        string result;

        Console.Write("Input a Number : ");
        num = Convert.ToInt32(Console.ReadLine());

        result = "";
        while (num > 1)
        {
            int remainder = num % 2;
            result = Convert.ToString(remainder) + result;
            num /= 2;
        }
        result = Convert.ToString(num) + result;
        Console.WriteLine("Binary: {0}", result);
    }
}

//5.
public class Fibbo
{
    public void Fiboseries()
    {
        int num;
        int temp;
        int k = 0;
        int j = 1;

        Console.WriteLine("Enter the number ");
        num = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < num; i++)
        {
            Console.WriteLine(k);
            temp = k + j;
            k = j;
            j = temp;
        }

    }
}

//4.
public class Year
{
    public void Leap()
    {
        int a;
        Console.WriteLine("Enter the Number 1");
        a = Convert.ToInt32(Console.ReadLine());

        if ((a % 4 == 0 && a % 100 != 0) || a % 400 == 0)
        {
            Console.WriteLine("This Year Is Leap year ", a);
        }
        else
        {
            Console.WriteLine("This Year Is not Leap year ", a);
        }

    }
}

//3.
public class Prime
{
    public  void Prim()
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
    }
}

//2.
public class Cal1
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

        if (Choice == 1)
        {
            Add = num + num1;
            Console.WriteLine("Addition {0}", Add);
        }
        else if (Choice == 2)
        {
            Sub = num - num1;
            Console.WriteLine("Addition {0}", Sub);
        }
        else if (Choice == 3)
        {
            Mul = num * num1;
            Console.WriteLine("Addition {0}", Mul);
        }
        else if (Choice == 4)
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

//1.
public class BMI
{
    public void Bmi()

    {
        double num;
        double num1;
        double height;
        double weight;
        double BMi;

        Console.WriteLine("Enter the Weight into pound");
        num = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the height into inches");
        num1 = double.Parse(Console.ReadLine());

        weight = num * 0.45359237;
        height = num1 * 0.0254;
        BMi = weight / height;

        Console.WriteLine("BMI is {0}", BMi);



    }
}
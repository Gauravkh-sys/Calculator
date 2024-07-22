// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int a, b, c;
Console.WriteLine("Enter First Number");
a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter Second Number");
b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Select Option To Perform Calculation");
int option;
Console.WriteLine("1. Addition");
Console.WriteLine("2. Subtraction");
Console.WriteLine("3. Multiplication");
Console.WriteLine("4. Division Quotient");
Console.WriteLine("5. Division Remainder");

option =Convert.ToInt32(Console.ReadLine());

switch (option)
{
    case 1:
        c = a + b;
        Console.WriteLine("Sum of Given {0} and {1} Number is:{2}", a, b, c);
        break;
    case 2:
        c = a - b;
        Console.WriteLine("Difference of Given {0} and {1} Number is:{2}", a, b, c);
        break;
    case 3:
        c = a * b;
        Console.WriteLine("Product of Given {0} and {1} Number is:{2}", a, b, c);
        break;
    case 4:
        try
        {
            if (b == 0)
            {
                Console.WriteLine("Number Should be Greater than Zero");
            }
            else
            {
                c = a / b;
                Console.WriteLine("Quotient of Given {0} and {1} Number is:{2}", a, b, c);
            }
        }
        catch(Exception ex)
        {
            Console.WriteLine("Divide by Zero Exception!!");
        }   
        break;
    case 5:
        c = a % b;
        Console.WriteLine("Remainder of Given {0} and {1} Number is:{2}", a, b, c);
        break;
    default:
        Console.WriteLine("Please Select Valid Option From List!!!");
        break;
}
    
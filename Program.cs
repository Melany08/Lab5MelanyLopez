
class Program
{
    
    static void Main(string[] args)
    {

Console.WriteLine("Beautiful Cat");
Console.WriteLine("==============================================================");
        Console.WriteLine("                x         x                ");
        Console.WriteLine("                xx       xx ");
        Console.WriteLine("                xxxxxxxxxxxx ");
        Console.WriteLine(@"               xxx/^\xx/^\xxx ");
        Console.WriteLine("               xx-xxxxxxxx-xx ");
        Console.WriteLine("                xxxxx___xxxx  ");
        Console.WriteLine("                 xx >><< xx   ");
        Console.WriteLine("                xxxxxxxxxxxx  ");
        Console.WriteLine("              xxxxxxxxxxxxxxxx  ");
        Console.WriteLine("             xxxxxxxxxxxxxxxxxx ");
        Console.WriteLine("            x (-|-|-) x (-|-|-) x ");
        Console.WriteLine("           xxxxxxxxxxxxxxxxxxxxxxx ");
        Console.WriteLine("           xxxxxxxxxxxxxxxxxxxxxxx ");
        Console.WriteLine("          xxxxxxxxxxxxxxxxxxxxxxxxx ");
        Console.WriteLine("          xxxxxxxxxxxxxxxxxxxxxxxxx ");
        Console.WriteLine("          xxxxxxxxxxxxxxxxxxxxxxxxx ");
        Console.WriteLine("          xxxxxxxxxxxxxxxxxxxxxxxxx ");
        Console.WriteLine("          xxxxxxxxxxxxxxxxxxxxxxxxx ");
        Console.WriteLine("           xxxxxxxxxxxxxxxxxxxxxxx ");
        Console.WriteLine("            xxxxxxxxxxxxxxxxxxxxx ");
        Console.WriteLine("            x (_|_|_) x (_|_|_) x ");
        Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx ");
        Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxx  xxx  xxxxxxxxxxxxxxxxxxx ");
        Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxx  xxx  xxxxxxxxxxxxxxxxxxx ");
        Console.WriteLine("                         xxx    ");
        Console.WriteLine("                        xxx    ");
        Console.WriteLine("                      xxx    ");
        Console.WriteLine("                      xxx    ");
        Console.WriteLine("                      xx    ");
        Console.WriteLine("                      xx    ");
        Console.WriteLine("                      xxx    ");
        Console.WriteLine("                       xxx  xx ");
        Console.WriteLine("                         xxx    ");


Console.WriteLine("Ask for and Input");
Console.WriteLine("-----------------------------------------------------------");


        Console.WriteLine("Function to calculate the sum of two numbers ");
        Console.WriteLine("Enter a number: ");
        int n1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter another number: ");
        int n2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("The sum of two numbers is : {0}", Sum(n1, n2));

        Console.WriteLine("Function to calculate the Substracts of two numbers ");
        Console.WriteLine("Enter a number: ");
        int nu1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter another number: ");
        int nu2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("The substraction of two numbers is : {0}", Substracts(nu1, nu2));


        Console.WriteLine("Function to calculate the Multiplies of two numbers ");
        Console.WriteLine("Enter a number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter another number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("The multiplication of two numbers is : {0}", Multiply(num1, num2));


        Console.WriteLine("Function to calculate the Divides of two numbers ");
        Console.WriteLine("Enter a number: ");
        int numb1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter another number: ");
        int numb2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("The Remainder of two numbers is : {0}", Divides(numb1, numb2));





        Console.WriteLine("MENU");
        Console.WriteLine("--------------------------------------------------");

        Console.WriteLine("Here are the options:");
        Console.WriteLine("1-Addition.");
        Console.WriteLine("3-Multiplication.");
        Console.WriteLine("4-Division.");
        Console.WriteLine("5-Exit.");
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("Choose an option");
        int opt;
        opt = Convert.ToInt32(Console.ReadLine());
        switch (opt)
        {
            case 1:
                Console.WriteLine("Enter a number: ");
                int number1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter another number: ");
                int number2 = Convert.ToInt32(Console.ReadLine());
                Console.Write("The Sum of {0}  and {1} is: {2}\n", number1, number2, number1 + number2);
                break;

            case 2:
                Console.WriteLine("Enter a number: ");
                int number3 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter another number: ");
                int number4 = Convert.ToInt32(Console.ReadLine());
                Console.Write("The Substraction of {0}  and {1} is: {2}\n", number3, number4, number3 - number4);
                break;

            case 3:
                Console.WriteLine("Enter a number: ");
                int number5 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter another number: ");
                int number6 = Convert.ToInt32(Console.ReadLine());
                Console.Write("The Multiplication of {0}  and {1} is: {2}\n", number5, number6, number5 * number6);
                break;

            case 4:
            Console.WriteLine("Enter a number: ");
                int number7 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter another number: ");
                int number8 = Convert.ToInt32(Console.ReadLine());
                if (number8 == 0)
                {
                    Console.Write("The second integer is zero. There is not an answer.\n");
                }
                else
                {
                    
                    Console.Write("The Division of {0}  and {1} is : {2}\n", number7, number8, number7 / number8);
                }
                break;

            case 5:
                break;

            default:
                Console.Write("Incorrect option");
                break;
        }

    }

    public static int Sum(int n1, int n2)
    {
        int total;
        total = n1 + n2;
        return total;
    }
    public static int Substracts(int nu1, int nu2)
    {
        int total1;
        total1 = nu1 - nu2;
        return total1;
    }
    public static int Multiply(int num1, int num2)
    {
        int total2;
        total2 = num1 * num2;
        return total2;
    }
    public static int Divides(int numb1, int numb2)
    {
        int total3;
        total3 = numb1 % numb2;
        return total3;
    }
}

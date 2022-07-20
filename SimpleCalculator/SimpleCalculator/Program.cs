
namespace SimpleCalculator
{
    class Program
    {

        static void Main(string[] args)
        {

            bool flag = true;
            Console.WriteLine("Welcome to our Calculator\n <---------------------------------------->");



                do
                {


                try
                {
                    Console.Write("Please Enter the first number:");
                    double firstNum = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Please Enter an Operator:");
                    string op = Console.ReadLine();


                    Console.Write("Please Enter the Second number:");
                    double secondNum = Convert.ToDouble(Console.ReadLine());

                    double result = Calculate(firstNum, secondNum, op);

                    Console.WriteLine("The Result of " + firstNum + op + secondNum + " is: " + result);



                    Console.Write("\nDo you wish to continue? (yes or no)");
                    string choice = Console.ReadLine();

                    if (String.Equals("no", choice) || String.Equals("No", choice))
                        flag = false;

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Invalid Choice");
                }

        } while (flag);

            
                Console.WriteLine("\n<---------------------------------------->\n" +
                    "Thank you for using our program, have a nice day!");
        }//End of Main



        static double Calculate(double num1, double num2, string op)
        {
            
                switch (op)
                {
                    case "+":
                        return (num1 + num2);
                        break;

                    case "-":
                        return (num1 - num2);
                        break;

                    case "*":
                        return (num1 * num2);
                        break;

                    case "/":
                        return (num1 / num2);
                        break;

                    default:
                        Console.WriteLine("Invaild Operator!!!!");
                        break;
                }//end of switch
      

                         return 0;
        
                        }//End of Calculate Method






    }//End of Class






}
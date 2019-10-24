using System;

namespace Assignment_1_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {

            Double firstNum;
            Double secoundNum;
            string operation;
            Double answer;


            Console.WriteLine("Hello , your are welcome to basic calculator!");

            Console.WriteLine(" operation like  x, / , +, -");

            Console.Write("Please enter first number:");
            // Console.ReadLine();
            firstNum = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine(" Enter your operation (x , / , + , - ) ");
            operation = Console.ReadLine();

            Console.Write("Plaese enter second number : ");
            // Console.ReadLine();
            secoundNum = Convert.ToInt32(Console.ReadLine());





            if (operation == "x")


            {
                answer = firstNum * secoundNum;
                // Console.ReadLine();

                Console.WriteLine(firstNum + "x" + secoundNum + " = " + answer);
                
                Console.ReadLine();

            }

            else if (operation == "/")

            {
                answer = firstNum / secoundNum;

                Console.WriteLine(firstNum + " / " + secoundNum + "  = " + answer);
                Console.ReadLine();

            }

            else if (operation == "+")


            { 
                answer = firstNum + secoundNum;

                Console.WriteLine(firstNum + " + " + secoundNum + " = " + answer);
                Console.ReadLine();


            }

        
            else if (operation == "-")


            {
                answer = firstNum - secoundNum;

                Console.WriteLine(firstNum + " - " + secoundNum + " = "  + answer);
                Console.ReadLine();
            
            }

            else
            {
                Console.Write(" Pres any key to continue"); 
                Console.WriteLine("sorry");
                Console.ReadLine();

               
            }
            //do
            {


            }// while (promter.Promt("Perss any key to continue ,  enter exit to quit", PromtOptions.Optional, "", paraeResultMethod: x =>.ToLowerInvariant()) 1= "EXIT");

           
    } 
    }

     

}

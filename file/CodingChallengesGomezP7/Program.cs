using System;
using System.Reflection;

namespace MyApp
{
    /*BLOCK OF TEXT or something
     * hi this my coding challenge thing, i just decided to put each challenge into its own method and add them to Main so i can change when theyre activated later (ps i did this)
     * got rid of all of those null warnings for the console.readline() commands by adding an ! after. this could cause a problem later but im pretty sure the check i added with all of them fixes that.
     * i guess ill just type here for random stuff like changes or something
     * ok so i did the select method thing! upkeep!! it kinda sucks though because i dont know how to use a list. and also im bad at safeguards rn.
     */
    internal class ProgramSum
    {
        static void Main(string[] args)
        {
            //welcome the user to my program
            Console.WriteLine("Welcome to my coding challenge program. I will be making a variety of functions for you to use.");
            SelectMethod();
        }

        static void SelectMethod()
        {
            Console.WriteLine(" \nPlease pick one from the list.\n0: Exit\n1: Sum\n2: Minutes to Seconds\n3: Plus One\n4: Circuit Power\n5: Days in Years\n6: Triangle Area\n7: Less than or Equal to 0");
            string num = Console.ReadLine()!;
            float parsed1;
            if (float.TryParse(num, out parsed1))
            {
                float temp;
                temp = parsed1;
                temp %= 1;//why is there a dot under the equal sign!!

                if (temp == 0 && parsed1 <= 7)
                {
                    //truly sickening if statements, ill do a list eventually
                    if (parsed1 == 0) { Environment.Exit(0); }
                    if (parsed1 == 1) { Adder(); }
                    if (parsed1 == 2) { minuteConvert(); }
                    if (parsed1 == 3) { plusOne(); }
                    if (parsed1 == 4) { Multiply(); }
                    if (parsed1 == 5) { daysInYear(); }
                    if (parsed1 == 6) { Area(); }
                    if (parsed1 == 7) { ToZero(); }
                }
                else
                {
                    Console.WriteLine("Please pick a valid number.");
                    SelectMethod();
                }
            }
            else
            {
                Console.WriteLine("Please pick a valid number.");
                SelectMethod();
            }
        }


        static void Adder()
        {
            Console.WriteLine("\n\nWe are going to use the number adder today called sum. Please give me two numbers.");

            string num1 = Console.ReadLine()!;
            int parsed1;
            while (!int.TryParse(num1, out parsed1))
            {
                Console.WriteLine("Please input a number.");
                num1 = Console.ReadLine()!;
            }


            Console.WriteLine("Got it, give me your second number.\n");

            string num2 = Console.ReadLine()!;
            int parsed2;
            while (!int.TryParse(num2, out parsed2))
            {
                Console.WriteLine("Please input a number.");
                num2 = Console.ReadLine()!;
            }

            int sum;
            sum = parsed1 + parsed2;

            Console.WriteLine("The sum of the number: " + num1 + " and the number: " + num2 + " is equal to: " + sum);
            SelectMethod();
        }

        static void minuteConvert()
        {
            Console.WriteLine("\n\nThis will tell how many seconds are in any number of minutes. \nGive me a number of minutes.");

            string num1 = Console.ReadLine()!;
            int parsed1;
            while (!int.TryParse(num1, out parsed1))
            {
                Console.WriteLine("Please input a number.");
                num1 = Console.ReadLine()!;
            }
            parsed1 *= 60;

            Console.WriteLine("\n" + num1 + " minutes has " + parsed1 + " seconds.");
            SelectMethod();
        }

        static void plusOne()
        {
            Console.WriteLine("\n\nWe are going to add +1 to a number. Please input that number.");

            string num = Console.ReadLine()!;
            int parsed;
            while (!int.TryParse(num, out parsed))
            {
                Console.WriteLine("Please input a number.");
                num = Console.ReadLine()!;
            }
            parsed++;

            Console.WriteLine("\n" + num + " + 1 = " + parsed);
            SelectMethod();
        }

        static void Multiply()
        {
            Console.WriteLine("\n\nWe are going to calculate the power with a specific voltage and current.\nPlease input the voltage.");

            string num1 = Console.ReadLine()!;
            int parsed1;
            while (!int.TryParse(num1, out parsed1))
            {
                Console.WriteLine("Please input a number.");
                num1 = Console.ReadLine()!;
            }

            Console.WriteLine("\nGot it, please input the current.");

            string num2 = Console.ReadLine()!;
            int parsed2;
            while (!int.TryParse(num2, out parsed2))
            {
                Console.WriteLine("Please input a number.");
                num2 = Console.ReadLine()!;
            }

            int result;
            result = parsed1 * parsed2;

            Console.WriteLine("The resulting power of " + parsed1 + " voltage and " + parsed2 + " current is " + result + " total power.");
            SelectMethod();
        }

        static void daysInYear()
        {
            Console.WriteLine("\n\nWe are going to calculate the number of days in a number of years.\nPlease put the number of years.");

            string num1 = Console.ReadLine()!;
            int parsed1;
            while (!int.TryParse(num1, out parsed1))
            {
                Console.WriteLine("Please input a number.");
                num1 = Console.ReadLine()!;
            }

            int days;
            days = parsed1 * 365;

            Console.WriteLine("There are " + days + " days in " + num1 + " years.");
            SelectMethod();
        }

        static void Area()
        {
            Console.WriteLine("\n\nhi today were gonna calculate the area of a triangle with the base and height.\nPlease put the height.");

            string hig = Console.ReadLine()!;
            float parsed1;
            while (!float.TryParse(hig, out parsed1))
            {
                Console.WriteLine("Please input a number.");
                hig = Console.ReadLine()!;
            }

            Console.WriteLine("\nCool, please input the base of the triangle.");
            //"base" doesnt work as the string here for some reason.
            string bas = Console.ReadLine()!;
            float parsed2;
            while (!float.TryParse(bas, out parsed2))
            {
                Console.WriteLine("Please input a number.");
                bas = Console.ReadLine()!;
            }

            float result = AreaTriangle(parsed1, parsed2);
            Console.WriteLine("The area of a triangle with a height of " + hig + " and a base of " + bas + " is " + result + ".");
            SelectMethod();
        }

        static float AreaTriangle(float hig, float bas)
        {
            //challenge said i had to specifically use "return" for this one so i am.
            float num = (bas * hig) / 2;
            return num;
        }

        static void ToZero()
        {
            Console.WriteLine("\n\nYou're going to put in a number and recieve a true or false if it is less than or equal to zero.\nPlease enter the number.");

            string num = Console.ReadLine()!;
            float parsed1;
            while (!float.TryParse(num, out parsed1))
            {
                Console.WriteLine("Please input a number.");
                num = Console.ReadLine()!;
            }

            if (parsed1 <= 0)
            {
                Console.WriteLine("True, the number is less than or equal to 0.");
            }
            else
            {
                Console.WriteLine("False, the number is larger than 0.");
            }
            SelectMethod();
        }
    }
}

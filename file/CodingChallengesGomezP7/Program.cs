using System;
using System.Numerics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MyApp
{
    /*BLOCK OF TEXT or something
     * hi this my coding challenge thing, i just decided to put each challenge into its own method and add them to Main so i can change when theyre activated later (ps i did this)
     * got rid of all of those null warnings for the console.readline() commands by adding an ! after. this could cause a problem later but im pretty sure the check i added with all of them fixes that.
     * i guess ill just type here for random stuff like changes or something
     * ok so i did the select method thing! upkeep!! it kinda sucks though because i dont know how to use a list. and also im bad at safeguards rn.
     * all the selectmethod calls in comments are leftovers from a while ago jsut ignore those
     */
    internal class ProgramSum
    {
        static void Main(string[] args)
        {
            //welcome the user to my program
            Console.WriteLine("Welcome to my coding challenge program. I will be making a variety of functions for you to use.");
            //string[] list = { "Exit", "Adder", "minuteConvert", "plusOne", "Multiply", "daysInYear", "Area", "ToZero" }; leftovers from a while ago
            Console.WriteLine(" \nPlease pick one from the list.\n1: Sum\n2: Minutes to Seconds\n3: Plus One\n4: Circuit Power\n5: Days in Years\n6: Triangle Area\n7: Less than or Equal to 0\n8: Less than 100\n9: Equal\n10: GiveSomething\n11: Reverse Boolean\n12: HoursToSeconds\n13: PolygonSidesAnglesSomethingIdk\n14: edabit\n15: and\n16: basketball\n17: perimeter\n18: helloName\n19: farm or something\n20: football\n21: months\n22: min and max");
            Console.WriteLine(); //empty line
            string num = Console.ReadLine()!;
            int parsed;
            if (int.TryParse(num, out parsed))
            {
                //DEBUG Console.WriteLine(parsed);
                if (parsed <= 30 && parsed >= 1)
                {
                    //DEBUG Console.WriteLine("call method " + list[parsed]);
                    //i didnt figure out how to do this better. ill figure it out eventually
                    if (parsed == 1) { Adder(); }
                    else if (parsed == 2) { minuteConvert(); }
                    else if (parsed == 3) { plusOne(); }
                    else if (parsed == 4) { Multiply(); }
                    else if (parsed == 5) { daysInYear(); }
                    else if (parsed == 6) { Area(); }
                    else if (parsed == 7) { ToZero(); }
                    else if (parsed == 8) { lessThan100(); }
                    else if (parsed == 9) { ifEqualTo(); }
                    else if (parsed == 10) { GiveMeSomething(); }
                    else if (parsed == 11) { ReverseBoolean(); }
                    else if (parsed == 12) { SecondsToHours(); }
                    else if (parsed == 13) { PolygonSides(); }
                    else if (parsed == 14) { Edabit(); }
                    else if (parsed == 15) { TrueandFalse(); }
                    else if (parsed == 16) { Basketball(); }
                    else if (parsed == 17) { Perimeter(); }
                    else if (parsed == 18) { helloName(); }
                    else if (parsed == 19) { farm(); }
                    else if (parsed == 20) { football(); }
                    else if (parsed == 21) { months(); }
                    else if (parsed == 22) { sortArray(); }
                    else if (parsed == 23) { Challenge23(); }
                    else if (parsed == 24) { Challenge24(); }
                    else if (parsed == 25) { Challenge25(); }
                    else if (parsed == 26) { Challenge26(); }
                    else if (parsed == 27) { Challenge27(); }
                    else if (parsed == 28) { Challenge28(); }
                    else if (parsed == 29) { Challenge29(); }
                    else if (parsed == 30) { Challenge30(); }
                }
            }
            else
            {
                Console.WriteLine("Please pick a valid function.");
            }
            /*leftover stuff
             ( float temp;
             temp = parsed;
             temp %= 1;

             if (temp == 0 && parsed <= 7)
             {
                 //truly sickening if statements, ill do a list eventually
                 if (parsed == 0) { Environment.Exit(0); }
                 else if (parsed == 1) { Adder(); }
                 else if (parsed == 2) { minuteConvert(); }
                 else if (parsed == 3) { plusOne(); }
                 else if (parsed == 4) { Multiply(); }
                 else if (parsed == 5) { daysInYear(); }
                 else if (parsed == 6) { Area(); }
                 else if (parsed == 7) { ToZero(); }
             }
             else
             {
                 Console.WriteLine("Please pick a valid function.");
                 SelectMethod();
             }
         }
         else
         {
             Console.WriteLine("Please pick a valid function.");
             SelectMethod();
         }*/
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
            //SelectMethod();
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
            //SelectMethod();
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
            //SelectMethod();
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
            //SelectMethod();
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
            //SelectMethod();
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
            //SelectMethod();
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
            //SelectMethod();
        }

        static void lessThan100()
        {
            Console.WriteLine("\n\nthis will take 2 numbers and determine if the sum is less than 100.\nplease input the first number");
            string num = Console.ReadLine()!;
            float parsed1;
            while ((!float.TryParse(num, out parsed1)))
            {
                Console.WriteLine("Please input a number.");
                num = Console.ReadLine()!;
            }
            Console.WriteLine("now input the second number.");
            string num1 = Console.ReadLine()!;
            float parsed2;
            while ((!float.TryParse(num1, out parsed2)))
            {
                Console.WriteLine("Please input a number.");
                num1 = Console.ReadLine()!;
            }

            float temp;
            temp = parsed1 + parsed2;
            if (temp < 100)
            {
                Console.WriteLine(parsed1 + " + " + parsed2 + " is less than 100.");
            }
            else
            {
                Console.WriteLine(parsed1 + " + " + parsed2 + " is not less than 100.");
            }
        }

        static void ifEqualTo()
        {
            Console.WriteLine("\n\nthis will take 2 numbers and determine if theyre the same value.\nPlease input the first number.");
            string num = Console.ReadLine()!;
            float parsed1;
            while ((!float.TryParse(num, out parsed1)))
            {
                Console.WriteLine("Please input a number.");
                num = Console.ReadLine()!;
            }
            Console.WriteLine("now input the second number.");
            string num1 = Console.ReadLine()!;
            float parsed2;
            while ((!float.TryParse(num1, out parsed2)))
            {
                Console.WriteLine("Please input a number.");
                num1 = Console.ReadLine()!;
            }

            parsed1 = parsed1 - parsed2;
            if (parsed1 == 0)
            {
                Console.WriteLine("The two numbers are the same.");
            }
            else
            {
                Console.WriteLine("The numbers are different.");
            }
        }

        static void GiveMeSomething()
        {
            Console.WriteLine("\n\nthis will return a string of \"something\" + whatever you input\nplease input the string");
            string something = Console.ReadLine()!;
            printsomething(something);
        }

        static void printsomething(string h)
        {
            Console.WriteLine("something " + h);
        }

        static void ReverseBoolean()
        {
            Console.WriteLine("\n\n hi this will take a bool value and reverse it\nput in \"true\" or \"false\" to choose true or false");
            bool theBool;
            while (!bool.TryParse(Console.ReadLine(), out theBool))
            {
                Console.WriteLine("Please input either \"true\" or \"false\".");
            }
            Console.WriteLine("you put in " + theBool + " so you get " + ReverseBoolValue(theBool));
        }

        static bool ReverseBoolValue(bool value)
        {
            value = !value;
            return value;
        }

        static void SecondsToHours()
        {
            Console.WriteLine("this method will convert however many hours you put in to an amount of seconds\nplease put in an integer");
            int hours;
            while(!int.TryParse(Console.ReadLine(),out hours))
            {
                Console.WriteLine("Please input a valid number.");
            }
            int seconds = hours * 3600;
            Console.WriteLine("there is " + seconds + " seconds in " + hours + " hours.");
        }

        static void PolygonSides()
        {
            Console.WriteLine("this method will tell you the sum of the internal angles of a polygon with however many sides you input\nplease input an integer greater than 2");
            int sides;
            while (!int.TryParse(Console.ReadLine(), out sides) || sides <= 2)
            {
                Console.WriteLine("Please input an integer greater than 2.");
            }
            int angleSum = (sides - 2) * 180;
            Console.WriteLine("the sum of the internal angles of a polygon with " + sides + " sides is " + angleSum + " degrees.");
        }

        static void Edabit()
        {
            Console.WriteLine("\nthis will take a string and will add \"edabit\" on the end.\nplease put a string.");
            var text = Console.ReadLine()!;
            Console.WriteLine(text + "Edabit");
        }

        static void TrueandFalse()
        {
            Console.WriteLine("this method will take two inputted boolean values and if both are true, will return \"true\", otherwise it will return \"false\".\nplease input the first bool.");
            bool bool1;
            bool bool2;
            while (!bool.TryParse(Console.ReadLine(), out bool1))
            {
                Console.WriteLine("Please input either \"true\" or \"false\".");
            }
            Console.WriteLine("great, input the second bool now pretty please");
            while (!bool.TryParse(Console.ReadLine(), out bool2))
            {
                Console.WriteLine("Please input either \"true\" or \"false\".");
            }
            Console.WriteLine("and(" + bool1 + ", " + bool2 + ") --> " + and(bool1, bool2));
        }

        static bool and(bool bool1, bool bool2)
        {
            if (bool1 && bool2) { return true; } else { return false; }
        }

        static void Basketball()
        {
            Console.WriteLine("this method will sum the score the amount of 2 and 3 pointers made\n how many 2 pointers were made");
            int twoP;
            int threeP;
            while (!int.TryParse(Console.ReadLine(), out twoP) || twoP < 0)
            {
                Console.WriteLine("please input a valid whole number");
            }
            Console.WriteLine("cool, how many 3 pointers were made?");//ow my hand is sore
            while (!int.TryParse(Console.ReadLine(), out threeP) || threeP < 0)
            {
                Console.WriteLine("please input a valid whole number");
            }
            Console.WriteLine("points("+ twoP + ", " + threeP + ") --> " + pointsBasket(twoP, threeP));
        }

        static int pointsBasket(int twoP, int threeP)
        {
            return (twoP * 2) + (threeP * 3);
        }

        static void Perimeter()
        {
            Console.WriteLine("hi this method will take 2 inputed values and determine a perimeter if a rectangle had those dimensions\nplease input the width");
            int width;
            int length;
            while (!int.TryParse(Console.ReadLine(), out width) || width <= 0)
            {
                Console.WriteLine("please input a valid value");
            }
            Console.WriteLine("cool, now input the length.");
            while (!int.TryParse(Console.ReadLine(), out length) || length <= 0)
            {
                Console.WriteLine("please input a valid value");
            }
            Console.WriteLine("the perimeter of a rectangle with a width of " + width + " and a length of " + length + " is " + perimeterCalc(width, length));
        }

        static int perimeterCalc(int width, int length)
        {
            return (2 * width) + (2 * length);
        }

        static void helloName()
        {
            Console.WriteLine("hi this will take a string you type and add \"Hello \" before it\nplease input the text");
            string name;
            name = Console.ReadLine()!;
            Console.WriteLine("\"Hello " + name + "!\"");
        }

        static void farm()
        {
            int chickens;
            int cows;
            int pigs;
            Console.WriteLine("ok this method will take the amount of chickens, cows, and pigs a farmer has from your inputs and output how many legs the animals have\nhow many chickens were there?(chickens have 2 legs each)");
            while(!int.TryParse(Console.ReadLine(),out chickens) || chickens < 0)
            {
                Console.WriteLine("please put a valid number of chickens");
            }
            Console.WriteLine("cool, now how many cows were there (4 legs)");
            while (!int.TryParse(Console.ReadLine(), out cows) || cows < 0)
            {
                Console.WriteLine("please put a valid number of cows");
            }
            Console.WriteLine("cool now how many pigs were there (4 legs)");
            while (!int.TryParse(Console.ReadLine(), out pigs) || pigs < 0)
            {
                Console.WriteLine("please put a valid number of pigs");
            }
            Console.WriteLine("animals(" + chickens + ", " + cows + ", " + pigs + ") --> " + legs(chickens, cows, pigs));
        }

        static int legs(int chickens, int cows, int pigs)
        {
            return (chickens * 2) + (cows * 4) + (pigs * 4);
        }

        static void football()
        {
            int wins;
            int draws;
            int losses;
            Console.WriteLine("hi football score thing wins = 3, draw = 1, loss = 0\nhow many wins did the team get");
            while(!int.TryParse(Console.ReadLine(), out wins) || wins < 0)
            {
                Console.WriteLine("please input a valid number");
            }
            Console.WriteLine("ok put how many draws the team had");
            while (!int.TryParse(Console.ReadLine(), out draws) || draws < 0)
            {
                Console.WriteLine("please input a valid number");
            }
            Console.WriteLine("ok last put how many losses the team had");
            while (!int.TryParse(Console.ReadLine(), out losses) || losses < 0)
            {
                Console.WriteLine("please input a valid number");
            }
            Console.WriteLine("FootballPoints(" + wins + ", " + draws + ", " + losses + ") --> " + footballScore(wins, draws, losses));
        }

        static int footballScore(int wins, int draws, int losses)
        {
            return (wins * 3) + (draws);
        }

        static void months()
        {
            int input;
            Console.WriteLine("hello, this method will return a month based on whatever you input. you should know what number returns what month.\nplease input a number between 1 and 12\n");
            while (!int.TryParse(Console.ReadLine(), out input) || input <= 0 || input > 12)
            {
                Console.WriteLine("please input a whole number between 1 and 12");
            }
            Console.WriteLine(monthName(input-1));
        }

        static string monthName(int m)
        {
            string[] months = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            return months[m];
            
        }

        static void sortArray()
        {
            Console.WriteLine("hi this method finds the minimum and maximum of an integer array you type in\nplease input your array with a comma seperating each number, like \"1, 2, 3\"\n");
            int[] array = ArrayInputandParse();
            while (array == null)
            {
                array = ArrayInputandParse();
            }
            Array.Sort(array);
            Console.WriteLine("[" + array[0] + ", " + array[array.Length - 1] + "]");
        }

        /* hi this method is not currently used, but im keeping it here for reference for later.
         * static void sortArrayMethod()
        {
            //ok i made 2 methods for this because if i didnt it would repeat the starting message every single time you were prompted to reinput after putting in a nonworking array
            string string1 = Console.ReadLine()!;
            while (string1 == null)
            {
                string1 = Console.ReadLine()!;
            }
            string[] tokens = string1.Split(",");
            int[] arr = new int[tokens.Length];
            for (int i = 0; i < tokens.Length; i++)
            {
                if (!int.TryParse(tokens[i], out arr[i]))
                {
                    Console.WriteLine("please input only whole number integers as your array\n");
                    sortArrayMethod();
                    return;
                }
                arr[i] = int.Parse(tokens[i]);
            }
            Array.Sort(arr);
            Console.WriteLine("[" + arr[0] + ", " + arr[arr.Length - 1] + "]");
        }**/

        static int[] ArrayInputandParse()
        {
            string string1 = Console.ReadLine()!;
            while (string1 == null)
            {
                string1 = Console.ReadLine()!;
            }
            string[] tokens = string1.Split(",");
            int[] arr = new int[tokens.Length];
            for (int i = 0; i < tokens.Length; i++)
            {
                if (!int.TryParse(tokens[i], out arr[i]))
                {
                    Console.WriteLine("please input only whole number integers as your array\n");
                    return null!; //null is intended and accounted for (hopefully)
                }
                arr[i] = int.Parse(tokens[i]);
            }
            return arr;
        }

        static void Challenge23()
        {
            //Take an array of integers (positive or negative or both) and return the sum of the absolute value of each element.
            Console.WriteLine("hi this takes an array you input and returns the sum of the absolute value of the array\nplease input your array with a comma seperating each number, like \"1, 2, 3\"\n");
            int[] array = ArrayInputandParse();
            while (array == null)
            {
                array = ArrayInputandParse();
            }
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Math.Abs(array[i]);
            }
            Console.WriteLine(absoluteArraySum(array));
        }

        static int absoluteArraySum(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum = sum + array[i];
            }
            return sum;
        }

        static void Challenge24()
        {
            //Create a function that takes a base number and an exponent number and returns the calculation.
            int a; int b;
            Console.WriteLine("hi this method will take two inputted numbers and returns the first number to the power of the second number\nplease input the first number\nalso if the number is too big it returns infinity so dont put it too high please");
            while (!int.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("please input a whole number");
            }
            while (!int.TryParse(Console.ReadLine(), out b))
            {
                Console.WriteLine("please input a whole number");
            }
            double sum = toThePower(a, b);
            Console.WriteLine(sum);
        }

        static double toThePower(int a, int b)
        {
            return Math.Pow(a, b);
        }

        static void Challenge25() //decided to change the naming schemes of the methods
        {
            //Create a function to multiply all of the values in an array by the amount of values in the given array.
            Console.Write("hi this method will take an array and multiply each value by the length of the array\nplease input your array with a comma seperating each number, like \"1, 2, 3\"\n");
            int[] array = ArrayInputandParse();
            while(array == null)
            {
                array = ArrayInputandParse();
            }
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = array[i] * array.Length;
            }
            Console.WriteLine("[{0}]", string.Join(", ", array));
        }

        static void Challenge26()
        {
            string string1;
            string string2;
            Console.WriteLine("hi this challenge gets a hamming distance between two inputted strings\nplease input the first string");

            string1 = Console.ReadLine()!;
            while (string1 == null)
            {
                Console.WriteLine("please input something");
                string1 = Console.ReadLine()!;
            }
            Console.WriteLine("cool now input the second string");

            string2 = Console.ReadLine()!;
            while(string2 == null || string2.Length != string1.Length)
            {
                Console.WriteLine("please input something that is as long as your first input (" + string1.Length + " characters)");
                string2 = Console.ReadLine()!;
            }

            int result = hammingDistance(string1, string2);
            Console.WriteLine(result);
        }
        static int hammingDistance(string first, string second)
        {
            int count = 0;
            for (int i = 0; i < first.Length; i++)
            {
                if(first[i] != second[i])
                {
                    count++;
                }
            }

            return count;
        }

        static void Challenge27()
        {
            //Create a function that accepts a string (of a person's first and last name) and returns a string with the first and last name swapped.
            Console.WriteLine("hi this switches \"firstname lastname\" to \"lastname firstname\"\nplease input your name like \"firstname lastname\" with only 1 space ");
            string string1 = Console.ReadLine()!;
            string[] tokens = string1.Split(" ");
            while (tokens.Length != 2)
            {
                Console.WriteLine("hi please input the name correctly, only a first and a last name seperated by a space\ninput it now");
                string1 = Console.ReadLine()!;
                tokens = string1.Split(" ");
            }
            Console.WriteLine(tokens[1] + " " + tokens[0]);
        }

        static void Challenge28()
        {
            //Create a function that returns the smaller number.
            int one;
            int two;
            Console.WriteLine("hi this compares 2 numbers for the smaller number\nplease input the first number");
            while (!int.TryParse(Console.ReadLine(), out one))
            {
                Console.WriteLine("please input a valid whole number");
            }
            Console.WriteLine("ok cool now input the second number");
            while (!int.TryParse(Console.ReadLine(), out two))
            {
                Console.WriteLine("please input a valid whole number");
            }
            if(one > two)
            {
                Console.WriteLine(two);
            }
            else if(one < two)
            {
                Console.WriteLine(one);
            }
            else if (one == two)
            {
                Console.WriteLine("equal");
            }
        }

        static void Challenge29()
        {
            Console.Write("hi this is a factorial of whatever you input\nplease input a number\n");
            int num = 5;
            while (!int.TryParse(Console.ReadLine(), out num))
            {
                Console.WriteLine("please input a valid whole number\n");
            }
            Console.WriteLine(factorial(num));
        }

        static int factorial(int input)
        {
            //im not sure if theres a factorial method but im making this anyways
           //also past like 17 this returns either a negative or 0? not sure what thats about maybe the number is just too big
            int num = 1;
            
            for (int i = 1; i < input+1; i++)
            {
                num *= i;
            }
            return num;
        }

        static void Challenge30()
        {
            string input;
            Console.WriteLine("hi put something and the method will count the vowels in it\nput a word");
            input = Console.ReadLine()!;
            Console.WriteLine(vowelsInString(input));
        }

        static int vowelsInString(string input)
        {
            int count = 0;
            for (int i = 0; i <  input.Length; i++)
            {
                if(input[i] == 'a' || input[i] == 'e' || input[i] == 'i' || input[i] == 'o' || input[i] == 'u') //theres probably a better way to do this
                {
                    count++;
                }
            }
            return count;
        }
    }
}
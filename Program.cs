using System;
using System.Linq;



namespace interview1
{
    class Program
    {
        static int CountSpace(string str)
        {
            int spacectr = 0;
            string str1;
            //for loop to increment through the string
            for (int i = 0; i < str.Length; i++)
            {
                //Substring will start at i and checks one index
                str1 = str.Substring(i, 1);
                if (str1 == " ")
                    //increment counter if a " " was found.
                    spacectr++;
            }
            return spacectr;
        }

        //Takes the string coming from StringName(), converts it to an array, reverses the array and returns the reversed array as a string
        static string ReverseName(string name)
        {
            char[] name1 = name.ToCharArray();
            Array.Reverse(name1);
            return new string(name1);
        }

        static string CapName(string name)
        {
            string name1 = name;
            char.ToUpper(name1[0]);
            char.ToUpper(name1[name1.Length - 1]);
            return new string(name1);
        }
        static void Pyramid()
        {
            Console.Write("\n***************************************************************\n");
            char ch = 'A';
            for (int i = 1; i <= 5; i++)
            {
                //For loop first inputs the " " before the starting ch
                for (int j = 5; j >= i; j--)
                    Console.Write(" ");
                //for loop to input and increment the ch
                for (int k = 1; k <= i; k++)
                    Console.Write(ch++);
                ch--;
                //for loop to decrease the ch from the previous position
                for (int m = 1; m < i; m++)
                    Console.Write(--ch);
                Console.Write("\n");
                ch = 'A';
            }
            Console.Write("***************************************************************\n");
        }

        static int Sum(string one, string two)
        {
            int un = Int32.Parse(one);
            int dos = Int32.Parse(two);
            int sum = un + dos;
            return sum;
        }

        static bool IsPal(string num)
        {
            string num1 = ReverseName(num);
            if (num == num1)
                return true;
            else
                return false;
        }

        static void LineCounter()
        {
            string str2;
            Console.Write("\n\nA function to count number of spaces in a sentence :\n");
            Console.Write("******************************************\n");
            Console.Write("Please input a string : ");
            str2 = Console.ReadLine();
            if (str2.Length < 2)
                Console.Write("Please have more than 2 characters!");
            else
                Console.WriteLine("\"" + str2 + "\"" + " contains {0} spaces", CountSpace(str2));
        }

        static void StringName()
        {
            Console.Write("\nA function to take your name and say it backwards");
            Console.Write("\nWhat is your name? \n");
            Console.Write("*************************\n");
            string str3 = Console.ReadLine();
            string rName;
            if (str3.Length < 2)
                Console.Write("Please have more than 2 characters!");
            else
            {
                rName = ReverseName(str3);
                Console.Write("Thank you " + str3 + ", if you look at your name backwards, it'll say: " + rName);
            }
        }

        static void CapsName()
        {
            Console.Write("\nA function to take your name and Capitalize the first and last characters \n");
            Console.Write("What is your name? \n");
            Console.Write("*************************\n");
            string str4 = Console.ReadLine();
            string cName = CapName(str4);
            Console.Write("Thank you " + str4 + ", Lets get funky and capitalize the first and last letters in your name! : " + cName);
        }
        static void Total()
        {
            Console.Write("\nA function to take two numbers and add them together \n");
            Console.Write("What is the first number? \n");
            Console.Write("*************************\n");
            string one = Console.ReadLine();
            Console.Write("Thanks! What is the second number? \n");
            string two = Console.ReadLine();
            int sum = Sum(one, two);
            Console.Write("The total of both those numbers is: " + sum);
        }

        static void Pal()
        {
            Console.Write("\nA function to check if your number is a palindrome! \n");
            Console.Write("What is your number? \n");
            Console.Write("*************************\n");
            string num = Console.ReadLine();
            bool palnum = IsPal(num);
            if (palnum == true)
                Console.Write("Thanks! It appears that your number is " + palnum + "ly a palindrome!\n");
            else
                Console.Write("Thanks! But it appears that " + num + " isn't very cool!");
        }

        static void MaxChar()
        {
            Console.Write("\nA function to check what character shows up the most! \n");
            Console.Write("\nWhat is your sentence? \n");
            Console.Write("*************************\n");
            string ch = Console.ReadLine();
            var res = ch.GroupBy(p => p).Select(p => new { Count = p.Count(), Char = p.Key }).GroupBy(p => p.Count, p => p.Char).OrderByDescending(p => p.Key).First();

            foreach (var r in res)
            {
                Console.WriteLine("The character that shows up the most is : {1} and it showed up {0} time(s)", res.Key, r);
            }

        }





        static void Main()
        {

            string option;
            Console.Write("\n***************************************************************");
            Console.Write("\nWhat would you like to do? : ");
            Console.Write("\nPress 1 to count the number of spaces in a string! : ");
            Console.Write("\nPress 2 to display a pyramid! : ");
            Console.Write("\nPress 3 to have your name said in reverse! : ");
            Console.Write("\nPress 4 to have your name Capitalized! : ");
            Console.Write("\nPress 5 to have two numbers be added up! : ");
            Console.Write("\nPress 6 To check if your number is a palindrome! : ");
            Console.Write("\nPress 7 To check what character shows up the most! :\n");
            Console.Write("***************************************************************\n");
            option = Console.ReadLine();
            if (option == "1")
                LineCounter();
            if (option == "2")
                Pyramid();
            if (option == "3")
                StringName();
            if (option == "4")
                CapsName();
            if (option == "5")
                Total();
            if (option == "6")
                Pal();
            if (option == "7")
                MaxChar();
        }
    }
}

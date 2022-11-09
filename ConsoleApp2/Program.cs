using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe
{
    //class is a container where we put code
    class Program
    {     
        //this is the starting part of my code
        //the code will read line by line, so the order matters a lot
        static void Main(string[] args)
        {
            Greeting();
        }
        static void Greeting()
        {
            Console.WriteLine("Hello! What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine($"Nice to meet you {name}");

            Console.ReadLine();
        }
        static void Variables()
        {
            //variables are amazing because they can store a specific data value we can use at any time
            //if you change what's in the variable you change what appears in the code
            string characterName = "John";
            //below is a different way of asigning something to a variable
            int characterAge;
            characterAge = 35;
            //console.writeline is an instruction to the console
            Console.WriteLine("There once was a man named " + characterName);
            //below is an exaple on concatonating of a string

            Console.WriteLine("He was " + characterAge + "years old");
            //you can change the value halfway through the code
            characterName = "Mike";

            Console.WriteLine("He really liked the name " + characterName);
            Console.WriteLine("But didn't like being " + characterAge);
            //without readline it will close without prompting
            Console.ReadLine();
            //to close the console hit enter or 'x' out of it
        }
        static void Structures()
        //data structures
        {
            string phrase = "Giraffe Attack";
            char grade = 'S';
            int age = 30;
            //decimal can be stored using these three structures going from least accurate to most accurate. float, double, decimal
            double gpa = 3.3;
            //boolean is a true or false value
            bool isMale = true;



            Console.ReadLine();
        }
        static void StringMethods()
        //woring with strings
        {
            // the use of \n will make a new line where as \"word\" will let you print out actual quotations
            //concatonation is adding 2 strings together
            string phrase = "Giraffe\n\"Academy\"" + "is pretty neat";
            //phrase.Length will print out the ammount of characters used
            //phrase.ToUpper() will make it caps
            //phrase.ToLower() will make it lower case
            //phrase.Contains("Giraffe") will have it print true because the string contains that word
            //phrase[0] will print out the first character
            //all indexes start with 0 unless otherwise specified
            //phrase.IndexOf("Academy") will tell you what index number Academy starts at at
            //if you put a character in .IndexOf() like z then you will get -1 to indicate that the index doesn't have that number
            //phrase.Substring(8) will only print out the string starting at that number
            //phrase.Substring(8,11) will only print out the chracters starting at 8 and ending at 11
            //google C# string methods to see other ways you can mess with strings
            Console.WriteLine(phrase);

            Console.ReadLine();

        }
        static void NumberMethods()
        //in c# you will work a lot with numbers
        {
            //you don't need "" to have you console print out numbers
            //any math problem typed inside of the () with automatically print out the answer not the problem
            // % will tell you the remained of a division problem
            // when using ints you will always get an int, even if that is techinically wrong
            //++ adds 1
            //-- subtracts 1
            //Math.Abs(-40) will give you the absolute value
            //Math.Pow(3,2) will give you 3 raised to the second power
            //Math.Sqrt(36) will give you the square root of a number
            //Math.Max(4,90) will tell you which number is bigger between the 2
            //Math.Min does the opposite
            //Math.Round(4.3) will round it to the closest number
            //google c# mathh methods for more cool stuff
            Console.WriteLine();

            Console.ReadLine();

        }
        static void UserInput()
        {
            //console.write() doesnt move to the next line

            Console.Write("Enter your name");
            //below is a method that waits for the user to put something
            //you can store a users answers into variables to use later in your code
            string name = Console.ReadLine();
            Console.WriteLine("Enter your age:");
            string age = Console.ReadLine();
            Console.WriteLine("Hello " + name + " you are " + age);

            Console.ReadLine();

        }
        static void CalculatorGame()
        {
            //to convert a string into a number do the following below
            //int num =   Convert.ToInt32("45");
            
            Console.WriteLine("Enter a number:");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter another number:");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(num1 + num2);

            Console.ReadLine();

        }
        static void MadLibs()
        {
            string color, pluralNoun, favoriteThings;

            Console.Write("Enter a color:");
            color = Console.ReadLine();
            Console.Write("Enter a Plural Noun:");
            pluralNoun = Console.ReadLine();
            Console.Write("Enter your favorite thing:");
            favoriteThings = Console.ReadLine();
            //a $ allows use to better use variables in console.writeline
            Console.WriteLine($"Roses are {color}");
            Console.WriteLine($"{pluralNoun} are blue");
            Console.WriteLine($"I love {favoriteThings}");

            Console.ReadLine();
        }
        static void Arrays()
        {
            //variables can only store 1 value
            //arrays can store multiple, think of it lie a collevtion of multiple values of the same type
            //remember that all indexes start with 0
            int[] luckyNumbers = { 14, 7, 13, 65, 36, 2};
            
            //if unsure of what to put into an array write it like below
            string[] friends = new string[5];
            //this way you can add strings up to the number inside the brackets, remember indexs start at 0
            //add to the array by doing whats below
            friends[0] = "Morgan";
            friends[1] = "Duane";
            friends[2] = "Lara";
            friends[3] = "Andrew";
            friends[4] = "KJ";
            friends[5] = "Tifa";

            //to change what's inside a variable do the following
            luckyNumbers[1] = 15;
            //the above has changed what would've been 7 into 15
            //[5] will print out 2
            Console.WriteLine(luckyNumbers[1]);

            Console.ReadLine();

        }
        static void Methods()
        {
            //methods are a block of code that can preform a specific task
            SayHi("Didgy", 27);
            Console.ReadLine();
        }
        //Here is how you properlly call a method
        //Methods should have about 5-10 lines of code
        //parameters are values that are passed fdrom method to the next
        static void SayHi(string name, int age)
        {
            Console.WriteLine($"Hello {name} you are {age}");
        }
        static void ReturnStatements()
        {
            //Cube(5) will not print out to console. It will run, you just won't see the result
            //Console.WriteLine(Cube(5)); is how to have it print properly
            double cubedNumber = Cube(5);
            Console.WriteLine(cubedNumber);

            Console.ReadLine();
        }
        //void means it won't return any information
        static double Cube(int num)
        {
            int resolve = num * num * num;
            //return means it will give a piece of information bac to the caller
            return resolve;
        }
    }
}

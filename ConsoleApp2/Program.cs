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
            UserInput();
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
    }
}

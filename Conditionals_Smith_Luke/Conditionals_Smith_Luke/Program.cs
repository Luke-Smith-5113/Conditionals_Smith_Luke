using System;

namespace Conditionals_Smith_Luke
{
    class Program
    {
        static void Main(string[] args)
        {
            //asks for a number and stores that number
            Console.WriteLine("Enter a number to be evaluated");
            int userNum = Convert.ToInt32(Console.ReadLine());
            //asks whether the number is a grade and stores that as a bool
            Console.WriteLine("Is this number a grade? answer true or false");
            bool userBool = Convert.ToBoolean(Console.ReadLine());
            //runs the method with the number and bool
            numCheck(userNum, userBool);

            //repeat code
            //asks for a new number and stores that number
            Console.WriteLine("Enter a number to be evaluated");
            int userNum2 = Convert.ToInt32(Console.ReadLine());
            //asks whether the number is a grade and stores that as a bool
            Console.WriteLine("Is this number a grade? answer true or false");
            bool userBool2 = Convert.ToBoolean(Console.ReadLine());
            //runs the method with the number and bool
            numCheck(userNum2, userBool2);

            //repeat code
            //asks for a new number and stores that number
            Console.WriteLine("Enter a number to be evaluated");
            int userNum3 = Convert.ToInt32(Console.ReadLine());
            //asks whether the number is a grade and stores that as a bool
            Console.WriteLine("Is this number a grade? answer true or false");
            bool userBool3 = Convert.ToBoolean(Console.ReadLine());
            //runs the method with the number and bool
            numCheck(userNum3, userBool3);
        }
        //method to test numbers
        static void numCheck(int methNum = 0, bool isGrade = false) 
        {
            //uses isgrade(userbool from earlier) to decide whether to test a number as a grade
            switch (isGrade)
            {
                //chooses what to do with non-grades
                case false:
                    //decides whether a number is even
                    int modNum = methNum % 2;
                    bool isEven = modNum == 0;
                    //decides whether a number is positive
                    bool isPos = methNum > 0;
                    //prints whether a number is positive and even with linebreaks to make things look neater
                    Console.WriteLine($"\nnumber is positive {isPos} and is even {isEven}\n");
                break;

                //chooses what to do with grades
                case true:
                    //makes a linebreak so things look neater
                    Console.WriteLine("\n");
                    //prints a result for the entered grade and a linebreak to make things neater
                    if (methNum >= 90) { Console.WriteLine("Superior"); Console.WriteLine("\n"); }
                    else if (methNum >= 80) { Console.WriteLine("Very Good"); Console.WriteLine("\n"); }
                    else if (methNum >= 70) { Console.WriteLine("Average"); Console.WriteLine("\n"); }
                    else if (methNum >= 60) { Console.WriteLine("Below Average"); Console.WriteLine("\n"); }
                    else { Console.WriteLine("Poor"); Console.WriteLine("\n"); }
                break;
            }
        }
    }
}

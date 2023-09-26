namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000 - DONE
        static void NumberLine()
        {

            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }

        }


        //Write a method that will print to the console numbers 3 through 999 by 3 each time
        static void ByThree()
        {
            for (int num1 = 3; num1 <= 999; num1 += 3)
            {
                Console.WriteLine(num1);
            }
        }


        //Write a method to accept two integers as parameterss and check whether they are equal or not - DONE

        public static void EqualNums()
        {
            Console.WriteLine("Enter two numbers");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 == num2)
            {
                Console.WriteLine("These numbers are equal");
            }
            else
            {
                Console.WriteLine("No, these numbers are not equal");
            }
        }

        //Write a method to check whether a given number is even or odd
        static void OddOneOut()
        {
            Console.WriteLine("Enter a number.");

            int userNum = Convert.ToInt32(Console.ReadLine());

            if (userNum % 2 == 0)
            {
                Console.WriteLine("This number is even steven.");
            }
            else
            {
                Console.WriteLine("This number is odd!");
            }
        }


        //Write a method to check whether a given number is positive or negative

        static void BankAcc()
        {
            Console.WriteLine("How much money do you have in your account?");
            int Money = Convert.ToInt32(Console.ReadLine());

            if (Money >= 0)
            {
                Console.WriteLine("This account is positive.");
            }
            else
            {
                Console.WriteLine("This account is negative.");
            }
        }

        //Write a method to read the age of a candidate and determine whether they can vote.
        static void VoteAge()
        {
            Console.WriteLine("How old are you?");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age >= 18)
            {
                Console.WriteLine("You can proceed and vote!");
            }
            else
            {
                Console.WriteLine("You cannot proceed, you are not old enough to vote.");
            }
        }
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()

        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10

        static void GuessNum()
        {
            Console.WriteLine("Enter a number.");
            int x = Convert.ToInt32(Console.ReadLine());

            if (x >= -10 && x <= 10)
            {
                Console.WriteLine("You are within range.");
            }
            else
            {
                Console.WriteLine("You are not within range.");
            }
        }

        //Write a method to display the multiplication table(from 1 to 12) of a given integer
        static void MultTable()
        {
            for (int row = 1; row <= 12; row++)
            {
                Console.Write(row + "\t");

                for (int col = 1; col <= 12; col++)
                {
                    if (row <= 12)
                    {
                        Console.Write(row * col + "\t");
                    }
                    else
                    {
                        Console.Write(col + "\t");
                    }

                }
                Console.Write("\n");
            }
        }

        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {
            NumberLine();
            ByThree();
            EqualNums();
            OddOneOut();
            BankAcc();
            VoteAge();
            GuessNum();
            MultTable();

        }
    }
}



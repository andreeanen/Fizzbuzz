using System;

namespace Fizzbuzz
{
    public class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            int inputIntegerFromUser = 0;
            program.InteractWithUser(inputIntegerFromUser);
            Console.ReadKey();
        }

        public void InteractWithUser(int input)
        {
            Program program = new Program();
            program.ConsoleLog("Enter a number between 1 and 300:");
            do
            {
                var inputFromUser = program.ReadInput();
                input = program.ValidateIntegerInput(inputFromUser);
                if (program.IsZero(input) || !program.ValidateRangeInput(input))
                {
                    program.ConsoleLog("Invalid input. Enter an integer between 1 and 300:");
                }
                else
                {
                    program.RunFizzbuzzCheck(input);
                }
            } while (program.IsZero(input) || !program.ValidateRangeInput(input));
        }

        public bool IsZero(int number)
        {
            return number == 0;
        }

        public bool RunFizzbuzzCheck(int input)
        {
            var program = new Program();
            int counter = 0;
            for (int i = 1; i <= input; i++)
            {
                counter++;
                string result = CheckValue(i);
                program.ConsoleLog(result);
            }
            return counter == input;
        }

        public string CheckValue(int i)
        {
            if (i == 42)
            {
                return "Answer to the Ultimate Question of Life, the Universe, and Everything";
            }
            if (i % 3 == 0 && i % 5 == 0)
            {
                return "Fizzbuzz";
            }
            if (i % 3 == 0)
            {
                return "Fizz";
            }
            if (i % 5 == 0)
            {
                return "Buzz";
            }
            return $"{i}";
        }

        public void ConsoleLog(string instruction)
        {
            Console.WriteLine(instruction);
        }

        public string ReadInput()
        {
            return Console.ReadLine();
        }

        public int ValidateIntegerInput(string input)
        {
            int result = 0;
            if(int.TryParse(input, out result))
            {
                return result;
            }
            return result;
        }

        public bool ValidateRangeInput(int inputInteger, int min = 1, int max = 300)
        {
            bool largerOrEqualThenMin = inputInteger >= min;
            bool lowerOrEqualThenMax = inputInteger <= max;
            if (largerOrEqualThenMin && lowerOrEqualThenMax)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

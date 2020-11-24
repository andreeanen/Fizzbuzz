using System;

namespace Fizzbuzz
{
    public class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            int inputIntegerFromUser;
            var isInputRangeValid = false;

            program.ConsoleLog("Enter a number between 1 and 300:");
            do
            {                
                var inputFromUser = program.ReadInput();
                inputIntegerFromUser = program.ValidateIntegerInput(inputFromUser);
                if (inputIntegerFromUser == 0)
                {
                    program.ConsoleLog("Invalid input. Enter an integer:");
                }
                else
                {
                    isInputRangeValid = program.ValidateRangeInput(inputIntegerFromUser);
                    if (!isInputRangeValid)
                    {
                        program.ConsoleLog("Invalid input. Enter an integer between 1 and 300:");                        
                    }
                    else
                    {
                        program.RunFizzbuzzCheck(inputIntegerFromUser);
                    }
                }
            } while (inputIntegerFromUser == 0 || !isInputRangeValid);

            Console.ReadKey();
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
            try
            {
                return int.Parse(input);
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public bool ValidateRangeInput(int inputInteger, int min = 1, int max = 300)
        {
            return (inputInteger > min && inputInteger < max);
        }
    }
}

using System;

namespace Fizzbuzz
{
    public class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.WriteInstruction("Enter a number between 1 and 300.");
            var inputFromUser = program.ReadInput();
            int inputIntegerFromUser = program.ValidateIntegerInput(inputFromUser);
            if (inputIntegerFromUser != 0)
            {
                var isInputRangeValid = program.ValidateRangeInput(inputIntegerFromUser);
                if (!isInputRangeValid)
                {
                    program.WriteInstruction("Your input was not a number betweeen 1 and 300. Good bye..");
                }
                else
                {
                    program.PrintResult(inputIntegerFromUser);
                }
            }
            else
            {
                program.WriteInstruction("Your input was not a number betweeen 1 and 300. Good bye..");
            }

            Console.ReadKey();
        }

        public bool PrintResult(int input)
        {
            var program = new Program();
            int counter = 0;
            for (int i = 1; i <= input; i++)
            {
                counter++;
                string result = CheckValue(i);
                program.WriteInstruction(result);
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

        public void WriteInstruction(string instruction)
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
                WriteInstruction("Your input was not a number... Good bye..");
                return 0;
            }
        }

        public bool ValidateRangeInput(int inputInteger, int min = 1, int max = 300)
        {
            return (inputInteger > min && inputInteger < max);
        }
    }
}

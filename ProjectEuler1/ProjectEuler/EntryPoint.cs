using InputOutputLibrary;
using OutputLibrary;
using ValidationLibrary;

namespace ProjectEuler
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            OutputService.WriteLine("Euler Project 1:");
            int range = -1;
            while (!ValidationService.IsPositive(range))
            {
                range = InputOutputService.GetIntFromPrompt("Input a range (positive int):");
                if (!ValidationService.IsPositive(range))
                {
                    OutputService.WriteLine("Please enter a positive integer.");
                }
            }

            int multiple1 = InputOutputService.GetIntFromPrompt("First multiple:");
            int multiple2 = InputOutputService.GetIntFromPrompt("Second multiple:");

            int totalSum = 0;
            for (int i = 1; i < range; i++)
            {
                if (i % multiple1 == 0 || i % multiple2 == 0)
                {
                    totalSum += i;
                }
            }

            OutputService.WriteLine("Final sum is " + totalSum + ".");
        }
    }
}

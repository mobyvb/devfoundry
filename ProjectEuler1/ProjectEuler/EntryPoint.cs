using InputOutputLibrary;
using OutputLibrary;
using ValidationLibrary;

namespace ProjectEuler
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            EulerProject1();

            OutputService.WriteLine("\n\n");

            EulerProject2();
        }

        public static void EulerProject1()
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

        public static void EulerProject2()
        {
            OutputService.WriteLine("Euler Project 2:");
            int limit = -1;
            while (!ValidationService.IsPositive(limit))
            {
                limit = InputOutputService.GetIntFromPrompt("Input a limit (positive int):");
                if (!ValidationService.IsPositive(limit))
                {
                    OutputService.WriteLine("Please enter a positive integer.");
                }
            }

            int totalSum = 0;

            int fibOld1 = 1;
            int fibOld2 = 1;
            int fibNew = 0;
            while (fibNew <= limit)
            {
                fibNew = fibOld1 + fibOld2;
                if (fibNew % 2 == 0)
                {
                    totalSum += fibNew;
                }

                fibOld2 = fibOld1;
                fibOld1 = fibNew;
            }

            OutputService.WriteLine("Final sum is " + totalSum + ".");
        }
    }
}

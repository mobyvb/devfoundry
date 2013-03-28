using InputLibrary;
using OutputLibrary;
using ValidationLibrary;
using ConversionLibrary;

namespace InputOutputLibrary
{
    public class InputOutputService
    {
        public static int GetIntFromPrompt(string prompt)
        {
            OutputService.WriteLine(prompt);
            string responseStr = InputService.ReadLine();
            if (ValidationService.ParsesAsInt(responseStr))
            {
                return ConversionService.ParseInt(responseStr);
            }

            OutputService.WriteLine("Please type an integer.");
            return GetIntFromPrompt(prompt);
        }
    }
}

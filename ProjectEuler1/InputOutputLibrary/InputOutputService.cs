



using ConversionLibrary;
using InputLibrary;
using OutputLibrary;
using ValidationLibrary;
namespace InputOutputLibrary
{
    public class InputOutputService
    {
        public static int GetIntFromPrompt(string prompt)
        {
            OutputLibrary.OutputService.WriteLine(prompt);
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

namespace H1_Temperature_converter
{
    internal class Program
    {
        static void Main()
        {
            // Writes in the console, that the user has to give input 
            Console.WriteLine("Write your temperature, in celcius");

            // Insuring that the program wont crash, if the user input is wrong
            try
            {
                // Creates a new local variable, which becomes the value of the user input, converted to double
                double celcius = double.Parse(Console.ReadLine());

                // Converts celcius to fahrenheit and Reaumur.
                double Fahrenheit = (celcius * 1.8) + 32;
                double Reaumur = celcius * 0.8;

                // Outputs the temperatures, to the console
                Console.WriteLine($"Fahrenheit is {Fahrenheit} and Reaumur is {Reaumur}");
            }
            catch
            {
                // Throws an error, which tells the user that they didnt input a valid number
                Console.WriteLine("You did not enter a valid number");
            }
        }
    }
}
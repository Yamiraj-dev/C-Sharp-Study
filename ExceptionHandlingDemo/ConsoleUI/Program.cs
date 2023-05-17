namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // an exception is something unexpected or unable to be handled.
            try
            {
                BadCall();
            }
            catch (Exception ex)
            {

                Console.WriteLine("There was an exception thrown.");
                Console.WriteLine(ex.Message);
            } 

            Console.ReadLine();
        }

        public static void BadCall()
        {
            int[] ages = new int[] { 1, 3, 5 };

            for (int i = 0; i <= ages.Length; i++)
            {

                try
                {
                    Console.WriteLine(ages[i]);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error has occurred.");
                    Console.WriteLine(ex.Message);
                    throw new Exception("There was an error an error handling our array", ex);
                }

            }
        }
    }
}

// We can try wrapping code in a try/catch block.
// The exception is handled in a try/catch block if we enter code into the catch block to handle an exception. 

// This however is bad handling of an exception as it just sweeps the problem under the rug. 
// "ex" is an unofficial standard for naming an exception.
// We can then print the message of why the error occurred.

// Throw in the catch block continues running code as if an exception was not there. 

// We wrap the badcall because it can catch an unhandled exception when one is thrown at it. 
namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RunsALot();
            Console.ReadLine();
        }

        private static void RunsALot()
        {
            long total = 0;
            int test = 0;

            for (int i = -1000 ; i <= 1000; i++)
            {
                total += i;
                try
                {
                    test = 5 / i;
                }
                catch (Exception)
                {

                    Console.WriteLine("There was an exception.");
                }
            }

            Console.WriteLine($"The total is {total}");
        }
    }
}

// We can set conditions for breakpoints.
// The rarely used condition is a filter
// Here, conditions iterating through each 100 loops shall be tested. We find that the exception occurs between loop -1 and 99.
// Set a new condition for when i is greater than -1 since that is where the problem seems to begin. 

// There are multiple ways of setting the condition, just logically set a condition that will get you closer to an idea of where the exception is thrown.

// Another way is just putting the breakpoint at the catch. 

// We can also ask the condition to show where this exception occurs with an output. 

// Adding labels to categorise our breakpoints helps keeping things organised. 

// Setting a breakpoint to a function can be done in the breaktpoints window.

// We can also export breakpoints for other developers to use, the export all breakpoints in the breakpoints window.
// Importing is done the same way, but you need the .XML file to import. 
namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string name = "";

            // Exceptions work in a hierarchy, the exception in our method is more specific than in the method being called.

            // In general, we only really need 1 exception to catch an error instead of going through things granularly. But in a database we can be specific and use more to enable backups to come into place. 
            // Exceptions indicate unexpected behaviour/s. You can create them yourself if it makes sense (Just like this demo)
            try
            {
                DifferentMethod();

                Console.Write("What is your name: ");
                name = Console.ReadLine();
                ComplexMethod(name);

                SimpleMethod();
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine("You should not be calling this dude.");
            }
            catch (NotImplementedException)
            {
                Console.WriteLine("You forgot to code this method.");
            }
            catch (Exception) when (name.ToLower() == "mus") // "when" allows us to set the condition when a certain statement is met.
            {
                Console.WriteLine("You are using Mus' name, aren't you?");
                //Console.WriteLine(ex.Message); 
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally // Finally runs regardless of everything else beforehand. It just runs code after trying to catch or when it does catch exceptions. 
            {
                Console.WriteLine("I will always run.");
            }            
            
            
            /* We can use multiple catches to try and figure out what went wrong, if it is an invalid operation we throw out the first exception and then move onto the 2nd one
            which is a more general type of exception.*/

            // Again, with exceptions working in a hierachy, we need the more general catch to be the last, because if it came first, any type of exception would qualify.
            // So it is best to work from most specific to least specific exception.

            Console.ReadLine();
        }

        private static void DifferentMethod()
        {
            Console.WriteLine("This is different method working properly.");
            //throw new NotImplementedException(); // Automatically generated code will throw out this type of exception.
            // This means that this method does not do anything, because of either forgetting to implement code or just neglecting it. 
        }

        private static void SimpleMethod()
        {
            throw new InvalidOperationException("You should not be calling this method."); // creates a new instance of the invalid operation
        }
        
        private static void ComplexMethod(string name)
        {
            if (name.ToLower() == "mus")
            {
                throw new InsufficientMemoryException("Mus is too tall for this method.");
            }
            else
            {
                throw new ArgumentException("This person isn't Yamiraj.");
            }
        }
        

    }
}


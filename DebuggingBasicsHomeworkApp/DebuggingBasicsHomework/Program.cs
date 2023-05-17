// Basic debugging

//BREAKPOINTS
using System.Security.Cryptography;

int number = 10;
int total = 0;

for (int i = 0; i < 10; i++)
{
    number = (number * 5);
    total = number + total;

    Console.WriteLine(total);
}


//EXCEPTION HANDLING

int[] numbers = new int[] { 1, 3, 5};

for (int i = 0; i <= numbers.Length; i++)
{
	try
	{
        Console.WriteLine(numbers[i]);
        Console.WriteLine("WASSUP");
    }
	catch (Exception ex)
	{
        Console.WriteLine("ERROR");
        Console.WriteLine(ex.Message);
       
	}
}


// we threw an exception because of equals to because a 4th value is not stored in our array. 
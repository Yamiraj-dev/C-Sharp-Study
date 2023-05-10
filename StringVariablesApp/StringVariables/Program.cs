//variables need to be defined by their type (in this case string)
//abbreviations are generally bad for naming variables
/*Hungarian notation is heavily discouraged and no longer in use
(where you name the variable with its type infront, such as strFirstName) */

string firstName = string.Empty; //can also be denoted by double quotes "" to say it is empty
string lastName = string.Empty;     
string filePath = string.Empty;


firstName = "Mustafa";
lastName = "Gonzales";

//firstName = "Mus"; this overwrites the previous assigned value
filePath = "C:\\Temp\\Demo"; //some characters are escape characters such as "\" 
                             // so we must use an escape character followed by the special character hence the double \\

//we can use @ to treat he string as a literal string and not recognize special characters
filePath = @"C:\Temp\Demo"; 


Console.WriteLine(firstName + " " + lastName);
//another way of doing this is with string interpolation
Console.WriteLine($"{firstName} {lastName}");

Console.WriteLine(filePath);

//lets mix a string literal and interpolation
string testString = $@"The file for {firstName} is at C:\SampleFiles";
Console.WriteLine(testString);
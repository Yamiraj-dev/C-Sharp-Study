// this is used to store date and time information

using System.Globalization;

DateTime today = DateTime.Now; // checks the current date and time when the code is run
// using DateTime.UtcNow allows to know what time it is on your end but you lose information about the offset 

Console.WriteLine(today);

// we can also specify formatting options using .toString 
Console.WriteLine(today.ToString("D")); // depending which format, in this case "D" which is long date, different outputs are shown

// DateTime birthday = DateTime.Parse("2/6/1998"); this follows the format of the computer's locale, so keep in mind of that

DateTime birthday = DateTime.ParseExact("6/2/1998", "d/M/yyyy", CultureInfo.InvariantCulture); /* CultureInfo.InvariantCulture and setting the format allows us
                                                                                               to change the format indifferent to the computer's locale*/

Console.WriteLine(birthday.ToString());

Console.WriteLine(today.ToString("dd MMMM yyyy hh:mm:ss tt zzz")); // this is just displaying the current time and date in a format along with the time zone


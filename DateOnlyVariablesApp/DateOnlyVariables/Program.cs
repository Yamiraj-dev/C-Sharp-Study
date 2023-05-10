// DateOnly applies when you just want the date, no time included

DateTime today = DateTime.Now;

DateOnly birthday = DateOnly.Parse("6/2/1998");

Console.WriteLine(birthday.ToString("MMMM dd, yyyy"));

Console.WriteLine($"Today full format: {today}");
Console.WriteLine($"Today date only: {today.Date}"); // this does not work because the current date's time is still shown
Console.WriteLine($"Birthday full format: {birthday}");
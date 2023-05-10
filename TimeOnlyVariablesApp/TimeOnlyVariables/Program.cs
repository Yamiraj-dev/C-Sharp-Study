// TimeOnly is the opposite of DateOnly, it works the same way
// TimeOnly does not care about the date 

TimeOnly opensAt = TimeOnly.Parse("8:00 AM");

TimeOnly rightNow = TimeOnly.FromDateTime(DateTime.Now);

Console.WriteLine(opensAt);
Console.WriteLine(rightNow.ToString("hh:mm tt"));
//doubles contain decimal points but can also hold integers with no decimal points - such as 1.23 and 45
double averageScore;

averageScore = (76.0 + 64 + 83) / 3; //this however returns an integer because of the int operator unless there is a decimal number

//type conversion can occur for a integer to double but not reversed because we lose data going from double to integer

Console.WriteLine(averageScore);
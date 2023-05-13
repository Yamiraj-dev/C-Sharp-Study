
// similar to a list, except each item has an assigned key of a certain type
// each item has an assigned key

Dictionary<string, string> lookup = new Dictionary<string, string>();

lookup["animal"] = "Not a human";
lookup["fish"] = "Not a human that swims";
lookup["human"] = "Us";

Console.WriteLine($"The definition of fish is {lookup["fish"]}");

Dictionary<int, string> employees = new Dictionary<int, string>();

employees[95] = "Mus Gonzales";
employees[28] = "Pia Po";

Console.WriteLine($"The employee with ID number 95 is {employees[95]}");

Dictionary<string, int> dayOfWeek = new Dictionary<string, int>();

dayOfWeek["Tuesday"] = 3;
dayOfWeek["Saturday"] = 6;
dayOfWeek["Sunday"] = 7;

Console.WriteLine($"Saturday is day number {dayOfWeek["Saturday"]}");

// we lookup through a key and not the item itself
// keys are like IDs, they cannot be duplicates  

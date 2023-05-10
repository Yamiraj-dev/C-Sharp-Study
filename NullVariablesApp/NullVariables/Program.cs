// Null - lack of value or the value is yet to be assigned
// You can edit out if you care about nullables in your project file by deleting <Nullable>enable</Nullable> in a project file


// Have not asked for age
// int age = 0; // 0 is a value because it assigns something
int? age = null;// we must assign the "?" character to the type to indicate it is nullable
                // typically in databases, we deal with a lot of nullable data
bool? birthday = null;
double? scoreAverage = null;    

string? fullName = null; // by default strings are nullable without using the "?" character
                        // we should still practice using the nullable character on strings


// We asked for the age
age = 5;

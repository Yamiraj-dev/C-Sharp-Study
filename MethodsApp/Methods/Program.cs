using Methods;
// we can shorthen samplemethods.sayhello by adding :
// using static Methods.SampleMethods; however we might run into ambiguous calls the more we shorten calls

// the context of this is in static void main
// static allows us to call methods without having to instatiate 


// DRY - Don't Repeat Yourself 
// Instead of copying code logic in multiple areas and it bugs out, we can refactor the code in one place so it works out in other areas
// Working on a method is better than fixing copied code in multiple areas

// SOLID - S (SRP) single responsbility principle 
ConsoleMessages.SayHello();
ConsoleMessages.SayGoodbye();
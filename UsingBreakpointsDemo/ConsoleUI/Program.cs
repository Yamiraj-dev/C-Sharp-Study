﻿

for (int i = 0; i < 20; i++)
{
    Console.WriteLine($"The value of i is {i}");
	for (int j = 0; j < 10; j++) // intentionally using the wrong parameter for incrementing
	{
        Console.WriteLine($"The value of j is {j}");
    }
}

Console.ReadLine();

//**A bug is an opportunity. DO NOT avoid it.
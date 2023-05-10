// Decimals are similar to doubles but is more precise, about 28 decimal places before rounding out
// It is expensive in terms of costing efficiency and storage
//Microsoft uses doubles for mathematic calculations due to efficiency and less storage cost

decimal bankBalance;

//bankBalance = 34.56; this line wouldn't work even though it contains a decimal point

bankBalance = 12.34M; //M is an indicator that the number is in fact a decimal and not a double or int

Console.WriteLine(bankBalance);
 

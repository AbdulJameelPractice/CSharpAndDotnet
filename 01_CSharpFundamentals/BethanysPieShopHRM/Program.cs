/*
Multiple line comment
Welcome to Bethany's Pie Shop HRM System!
*/

using BethanysPieShopHRM;

Console.WriteLine("Welcome to Bethany's Pie Shop HRM System!");

// Console.WriteLine("Please enter your username:");

// var username = Console.ReadLine();

// Console.WriteLine("Please enter your password:");

// // enter password without showing it on the screen

// var password = Console.ReadLine();


// if (username == "admin" && password == "password")
// {
//     Console.WriteLine("Hi there, superuser!");

// }
// else
// {
//     Console.WriteLine("Invalid username or password.");
// }

// Console.WriteLine("Press any key to exit...");
// Console.ReadLine();

//double ratePerHour = 15.25;
//int numberOfHoursWorked = 165;

//int maxValue = int.MaxValue;
//int minValue = int.MinValue;

//// Prints The range of integers is -2147483648 to 2147483647.
//Console.WriteLine($"The range of integers is {minValue} to {maxValue}.");

//char userSelection = 'a';
//char upperCase = char.ToUpper(userSelection);
//bool isDigit = char.IsDigit(userSelection);
//bool isLetter = char.IsLetter(userSelection);

//Console.WriteLine($"The uppercase of {userSelection} is {upperCase}.");
//Console.WriteLine($"Is '{userSelection}' a digit? {isDigit}.");
//Console.WriteLine($"Is '{userSelection}' a letter? {isLetter}.");

//double currentMonthWage = ratePerHour * numberOfHoursWorked;

//Console.WriteLine($"Your current wage is {s}.");

//DateTime today = DateTime.Today;
//DateTime dateTime = new DateTime(2024, 1, 13);

//Console.WriteLine($"Today is {today}.");
//Console.WriteLine($"The date is {dateTime}.");

//DateTime startDate = today.AddDays(12);
//Console.WriteLine($"The start date is {startDate}.");

//// throws error at run time
////DateTime endDate = new DateTime(2024, 13, 13);


//long veryLongMonth = numberOfHoursWorked; // works fine explicit cast

//double d = 123456789.0;
////int i = d; // throws error at compile time
//int i = (int)d; // explicit

//Console.WriteLine($"The double is {d}.");
//Console.WriteLine($"The integer is {i}.");

double currentYearWage = HelperUtility.CalculateYearlyWage(15, 165);
Console.WriteLine($"Your current wage is {currentYearWage}.");

double currentYearWageForAbdul = HelperUtility.CalculateYearlyWage(15, 165, 1000);
Console.WriteLine($"Abdul current wage is {currentYearWageForAbdul}.");

double currentYearWageForAbdulJameel = HelperUtility.CalculateYearlyWage(15, 165, 1000.50);
Console.WriteLine($"Abdul Jameel current wage is {currentYearWageForAbdulJameel}.");

// named parameters, need to specify the parameter name and pass all the parameters
double withNamedParameters = HelperUtility.CalculateYearlyWage(numberOfHoursWorked: 165, ratePerHour: 15);
Console.WriteLine($"With NamedParameters current wage is {withNamedParameters}.");


int a = 42;
int aCopy = a;

Console.WriteLine($"a is {a}.");
Console.WriteLine($"aCopy is {aCopy}.");

a = 52;

Console.WriteLine($"a is {a}.");
Console.WriteLine($"aCopy is {aCopy}.");

int? aValue = null;
Console.WriteLine($"aValue is {aValue}.");
aValue = aValue ?? 20;
Console.WriteLine($"aValue is {aValue}.");


List<string> aList = new List<string>();
for (int i = 0; i < 95822121; i++)
{
    aList.Add(true.ToString());
}

GC.Collect();


Console.WriteLine("Press any key to exit...");
Console.ReadLine();
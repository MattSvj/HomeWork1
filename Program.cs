/*
//задача 1
Console.Write("Input int number: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Result is " + num*num);
*/
//задача 2
/*
Console.Write("Input first int number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second int number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if(num1 == num2 * num2)
    Console.WriteLine("First number is a quad of second number");
else
    Console.WriteLine("First number is not a quad of second number");
*/
//задача 3
/*
Console.Write("Input num of weekday: ");
int day = Convert.ToInt32(Console.ReadLine());

if(day > 7 || day < 1)
    Console.WriteLine("Incor number of day!");
else
{
    if(day == 1)
        Console.WriteLine("Its monday");
    if(day == 2)
        Console.WriteLine("Its tuesday");
    if(day == 3)
        Console.WriteLine("Its sreda");
    if(day == 4)
        Console.WriteLine("Its chetverg");
    if(day == 5)
        Console.WriteLine("Its Пятница");
    if(day == 6)
        Console.WriteLine("Its Суббота");
    if(day == 7)
        Console.WriteLine("Its Воскресенье");
}
*/
//задача 4
/*
Console.Write("Input int num ");
int num = Convert.ToInt32(Console.ReadLine());
int current = -1 * num;

while(current <= num)
{
    Console.Write(current + " ");
    current++;
}   
*/
//задача 5
Console.Write("Input int num ");
int num = Convert.ToInt32(Console.ReadLine());

if(num < 100 || num > 999)
    Console.WriteLine("Inc num");
else
{
    int a = num % 10;
    Console.WriteLine("Res num is " + a);
}


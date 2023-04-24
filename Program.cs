//Задача2
/*Console.WriteLine("Input your first number");
int number_a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input your first number");
int number_b = Convert.ToInt32(Console.ReadLine());
if (number_a > number_b)
{
    Console.WriteLine($"Max number is {number_a}. Min number is {number_b}");
}
else Console.WriteLine($"Max number is {number_b}. Min number is {number_a}");
*/


//Задача 4
/*Console.WriteLine("Input your first number");
int number_a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input your second number");
int number_b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input your third number");
int number_c = Convert.ToInt32(Console.ReadLine());
int max = number_a;
if (number_b > number_a)
{
    max = number_b;
}
if (number_c > max)
{
    max = number_c;
}

Console.WriteLine($"Max number is {max}");
*/

//Задача 6
/*Console.WriteLine("Input your  number");
int number = Convert.ToInt32(Console.ReadLine());
if (number % 2 == 0)
{
    Console.WriteLine("Your number is even number");
}
else 
{
    Console.WriteLine("Your number is not even number");
}
*/


//Задача 8
Console.WriteLine("Input your  number");
int N = Convert.ToInt32(Console.ReadLine());
int current_i = 0;
while (current_i <= N)
{
if (current_i % 2 == 0)
{
    Console.WriteLine(current_i + " ");
    current_i = current_i + 2;
}    
}

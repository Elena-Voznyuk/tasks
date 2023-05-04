//Задача 2
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
/*Console.WriteLine("Input your  number");
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
*/


//Задача 10

/*void Digit(int num);
{
if (num > 99 && num < 1000)
{
    int a = num / 10;
    int b = a % 10;
    Console.WriteLine($"Your number is {b}");
}
else 
{
    Console.WriteLine("Your number is not three-digit!");
}
}
Console.WriteLine("Input your number:");
int number = Convert.ToInt32(Console.ReadLine());
Digit(number);
*/


//Задача 13

/*void Digit(int num)
{
if (num > 999)
{
    while (num > 999)
    {
      int number_a = num / 10;
      num = num * 1; 
    } 
} 
else 
{
    if (num < 999 && num > 99) 
    {
        int number_a = num /10;
        int number_b = num % 10;
        int res = number_a * 0 + number_b;
        Console.WriteLine($"Your third number is {res}");
    }
    else
    {
        Console.WriteLine("This is not a third number");
    }   
}  
}


Console.WriteLine("Input your number:");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 99)
{
    Digit(number);
}
else 
{
    Console.WriteLine("It is not the third digit!");
}

*/


//Задача 15


void Saturdays(int num)
{
    if (num == 6 || num == 7)
    {
        Console.WriteLine("This is day off!");
    }
    else 
    {
        Console.WriteLine("This is not day off!");
    }
    }
    Console.WriteLine("Input your number");
    int number = Convert.ToInt32(Console.ReadLine());
    Saturdays(number);

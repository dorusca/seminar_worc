/* Задача  10: Напишите программу, которая принимает 
на вход трёхзначное число и на выходе показывает 
вторую цифру этого числа.

int Three(int num)
{
int num1 = Convert.ToInt32(Console.ReadLine ());
int current = num /10;
int current1 = current % 10;


if (num > 99 &&  num < 1000)
{
Console.WriteLine ( $"Новое число {current1}");
return current1;
}
else Console.WriteLine ( $" Число {num1} не трехначное !");
return num1;
}

Console.WriteLine("Введите трехначное число:  ");
int num = Convert.ToInt32(Console.ReadLine ());

Console.WriteLine("Ваше новое число {Three (current1)}");


Задача 13: Напишите программу,  которая выводит третью цифру 
заданного числа или сообщает, что третьей цифры нет.


Console.WriteLine ( " Введите N:  ");
int num = Convert.ToInt32(Console.ReadLine ());

while (num >=1000 ) num = (num /10 );

if (num > 99 &&  num < 1000)
{
int current = num % 10;
Console.WriteLine ( $"Новое число {current}");
}
else  Console.WriteLine ( $" Число {num } не трехначное !Введите другое число:  ");



Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день
 недели, и проверяет, является ли этот день выходным.
*/

int A_Week ()
{
int random= new Random().Next (1,8);
Console.WriteLine ( $"Ваше число {random}");
if (random < 6)
{
Console.WriteLine ( $"{random} - рабочий день.");
return random;
}
else Console.WriteLine ( $"{random} - выходной день.");
return random;
}
A_Week ();

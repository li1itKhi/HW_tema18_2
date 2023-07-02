/*Напишите программу, которая принимает от пользователя строку,
содержащую числа, разделенные запятой. Используя метод Split(),
разделите строку на отдельные числа и найдите их сумму. Выведите
полученную сумму на экран*/

using System.Text.RegularExpressions;

Console.Write("Введите целые числа через запятую: ");
string numbers=Console.ReadLine()!;

string[]result = numbers.Split(',');

int summa = 0;

for(int i = 0; i < result.Length; i++)
{
    summa+=Convert.ToInt32(result[i]);
}

Console.WriteLine("Сумма чисел = "+summa);

/*Напишите программу, которая запрашивает у пользователя
предложение и определяет, сколько слов в нем содержатся. Для этого
используйте метод Split() для разделения предложения на отдельные
слова и подсчитайте их количество. Выведите полученное число на
экран.*/

Console.Write("Введите предложение: ");
string words = Console.ReadLine()!;

string[] result_2 = words.Split(',',':','.','!','?',';', ' ');

int count = 0;

for(int i=0; i < result_2.Length; i++)
{
    count++;
}
Console.WriteLine("Символов в строке: "+count);
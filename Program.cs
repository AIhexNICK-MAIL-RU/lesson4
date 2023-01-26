/* Задача 25: Напишите цикл, который принимает на вход два 
числа (A и B) и возводит число A в натуральную степень B. 
Задание должно быть выполнено в методе. В методе не должно 
быть вывода в консоль.
3, 5 -> 243 (3⁵)
2, 4 -> 16 */

bool isParsed = int.TryParse(Console.ReadLine(), out int a);
bool isParsed1 = int.TryParse(Console.ReadLine(), out int b);

int noun = GetNounNumbers(a);

Console.WriteLine(noun);

int GetNounNumbers(int b)
{
    int noun = a;

    for (int i = 0; i <= b; i++)
    {
        noun *= a;
    }
    return noun;
}
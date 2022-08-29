// Задача 41. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3


int m = 5;
int[] mNumbers = new int[m];

void InputNumbers(int m)
{
    for (int i = 0; i < m; i++)
    {
        Console.Write($"Введи {i+1} число: ");
        mNumbers[i] = int.Parse(Console.ReadLine());
    }
}


int Comparison(int[] massiveNumbers)
{
    int count = 0;
    for (int i = 0; i < mNumbers.Length; i++)
    {
        if(massiveNumbers[i] > 0 ) count += 1; 
    }
    return count;
}

InputNumbers(m);

Console.WriteLine($"Чисел > 0 ---> {Comparison(mNumbers)} ");
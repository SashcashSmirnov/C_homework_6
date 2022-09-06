//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, 
//сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 4

/*

int[] CreateArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Введите {i + 1} значение: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

int zero_plus(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }
    return count;
}



Console.Write("Введите количество чисел для подсчета: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = CreateArray(size);
int zeroplus = zero_plus(array);
Console.WriteLine($"Количество чисел больше нуля: {zeroplus}");

*/

//Задача 43: Напишите программу, которая найдёт точку пересечения 
//двух прямых, заданных уравнениями 
//y = k1 * x + b1, 
//y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

/*

Console.WriteLine("Задайте координаты начала и конца двух отрезков.");
Console.Write("Координата b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Координата k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Координата b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Координата k1: ");
double k2 = Convert.ToDouble(Console.ReadLine());

double x = (b2 - b1) / (k1 - k2);
double y = k1 * ((b2 - b1) / (k1 - k2)) + b1;

Console.WriteLine($"Две прямые пересекутся в точке с координатами X: {x}, Y: {y}");

*/
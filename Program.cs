Console.WriteLine("1. Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран");
Console.WriteLine("=========================");
Console.WriteLine("2. Определить, присутствует ли в заданном массиве, некоторое число");
Console.WriteLine("=========================");
Console.WriteLine("3. Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных и четных чисел");
Console.WriteLine("=========================");
Console.WriteLine("4. В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]");
Console.WriteLine("=========================");
Console.WriteLine("5. Найти сумму чисел одномерного массива стоящих на нечетной позиции");
Console.WriteLine("=========================");
Console.WriteLine("6. Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.");
Console.WriteLine("=========================");
Console.WriteLine("7. В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом");
Console.WriteLine("=========================");
Console.Write("Укажите цифру задания: ");
int zadanie = int.Parse(Console.ReadLine()!);
Console.WriteLine("=========================");

if(zadanie == 1)
{
//Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран
Console.WriteLine("1. Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран");
int lenght = 8;
int[] array = new int[lenght];
Random rand = new Random();

for(int i = 0; i < lenght; i++)
{
array[i] = rand.Next(0, 2);
Console.WriteLine(array[i]);
}
}

if(zadanie == 2)
{
//Определить, присутствует ли в заданном массиве, некоторое число
Console.WriteLine("2. Определить, присутствует ли в заданном массиве, некоторое число");
int lenght = 10;
int[] array = new int[lenght];
Random rand = new Random();

Console.WriteLine("Минутку, создается массив");

for(int i = 0; i < lenght; i++)
{
    array[i] = rand.Next(0, 20);
    Console.WriteLine(array[i]);
}

Console.Write("Введите число, которое нужно найти в массиве: ");
int number = int.Parse(Console.ReadLine()!);
bool found = false;
for(int i = 0; i < lenght; i++)
{
    if(array[i] == number)
    {
        found = true;
    }
}
if(found) 
{
    Console.WriteLine("=================================");
    Console.WriteLine("Число " + number + " в массиве присутвует");
    Console.WriteLine("=================================");
}
else
{
    Console.WriteLine("=================================");
    Console.WriteLine("Число " + number + " в массиве отсутсвует");
    Console.WriteLine("=================================");
}
}

if(zadanie == 3)
{
//Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел
Console.WriteLine("Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных и четных чисел");
Console.WriteLine("Минутку, создается массив");
int lenght = 10;
int[] array = new int[lenght];
Random rand = new Random();
int sum_1 = 0;
int sum_2 = 0;


for(int i = 0; i < lenght; i++)
{
    array[i] = rand.Next(100, 1000);
    Console.WriteLine(array[i]);  

    if(array[i] % 2 == 0)
        {
        sum_1++;
        }
    else
        {
        sum_2++;
        }
}
Console.WriteLine("================================="); 
Console.WriteLine("Количество четных чисел: " + sum_1);
Console.WriteLine("Количество четных чисел: " + sum_2);
Console.WriteLine("=================================");
}

if(zadanie == 4)
{
//В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]
Console.WriteLine("В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]");
int lenght = 123;
int[] array = new int[lenght];
Random rand = new Random();
int sum = 0;
int i = 0;

Console.Write("Укажите минимальное число диапазона поиска: ");
int minimum = int.Parse(Console.ReadLine()!);
Console.Write("Укажите максимальное число диапазона поиска: ");
int maximum = int.Parse(Console.ReadLine()!);

while(i < lenght)
{
    array[i] = rand.Next(minimum, maximum);
    Console.WriteLine(array[i]);  
        if(array[i] >= 10 && array[i] <= 99)
        {
        sum++;
        }
    i++;
}
Console.WriteLine("================================="); 
Console.WriteLine("Количество элементов из отрезка [10,99]: " + sum);
Console.WriteLine("=================================");
}

if(zadanie == 5)
{
//Найти сумму чисел одномерного массива стоящих на нечетной позиции
Console.WriteLine("Найти сумму чисел одномерного массива стоящих на нечетной позиции");
int lenght = 10;
int[] array = new int [lenght];
Random rand = new Random();
int sum = 0;
int i = 0;

while(i < lenght)
{
    array[i] = rand.Next(0, 25);
    Console.WriteLine(array[i]);
    if(array[i] % 2 != 0)
    {
        sum = sum + array[i];
    }
i++;
}
Console.WriteLine("=================================");
Console.Write("Сумма нечетных чисел равна: "); 
Console.WriteLine(sum);
Console.WriteLine("=================================");
}

if(zadanie == 6)
{
//Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.
Console.WriteLine("Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.");
int lenght = 10;
int[] array = new int [lenght];
Random rand = new Random();
int proizvedenie = 0;
int i = 0;

Console.Write("Укажите минимальное число диапазона: ");
int minimum = int.Parse(Console.ReadLine()!);
Console.Write("Укажите максимальное число диапазона: ");
int maximum = int.Parse(Console.ReadLine()!);


while(i < lenght)
{
    array[i] = rand.Next(minimum, maximum);
    Console.WriteLine(array[i]);
    i++;
}
Console.WriteLine("==========================");
i = 0;
while(i < lenght / 2)
{
    proizvedenie = array[i] * array[lenght - i -1];
    Console.WriteLine(proizvedenie);
    i++;
}
}

if(zadanie == 7)
{
//В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом
Console.WriteLine("В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом");
int lenght = 10;
double[] array = new double[10];
Random rand = new Random();

for(int i = 0; i < lenght; i++)
{
    array[i] = rand.Next(-990, 990)/10.0;
    Console.WriteLine(array[i]);
}

double min = array[0];
for(int i = 0; i < lenght; i++)
{
    if(array[i] < min)
    min = array[i];
}
double max = array[0];
for(int i = 0; i < lenght; i++)
{
    if(array[i] > max)
    max = array[i];
}
Console.WriteLine("=========================");
Console.WriteLine("Минимальное число в массиве: " + min);
Console.WriteLine("Максимальное число в массиве: " + max);
Console.WriteLine("=========================");
double raznica = max - min;

Console.WriteLine("Разница: " + raznica);
Console.WriteLine("=========================");
}
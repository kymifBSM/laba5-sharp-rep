////////////////task1/////////////////////////

/*Console.WriteLine("Задание 1. Введите x и y (вычислить выражение c=y*tgy+tgy): ");

static double Tan(double x1)
{
    return Math.Sin(x1) / Math.Cos(x1);
}

double y1 = Double.Parse(Console.ReadLine());
double x1 = Double.Parse(Console.ReadLine());

double tg = Tan(x1);
double c1 = y1 * tg + tg;

Console.WriteLine($"Ответ: c = {c1}");

////////////////task2/////////////////////////

Console.WriteLine("Задание 2. Введите градусы для преобразования в радианы: ");

static double DegreesToRadians(double degrees)
{
    return degrees * Math.PI / 180.0;
}

double degrees = Double.Parse(Console.ReadLine());
double radians = DegreesToRadians(degrees);

Console.WriteLine($"Ответ: {radians} рад");

////////////////task3/////////////////////////

Console.WriteLine("Задание 3. Счётчик количества цифр, введите числа: ");
static int CountDigits(int x2)
{
    int count = 0;

    while (x2 != 0)
    {
        count++;
        x2 /= 10;
    }

    return count;
}

int x2 = Int32.Parse(Console.ReadLine());
int сount2 = CountDigits(x2);

Console.WriteLine($"Количество цифр в записи: {сount2}");*/

////////////////ADDITIONAL TASKS//////////////


////////////////task1/////////////////////////
using Microsoft.Win32.SafeHandles;

static bool Prime(int n1)
{
    if (n1 <= 1)
    {
        return false;
    }

    for (int i = 2; i <= Math.Sqrt(n1); i++)
    {
        if (n1 % i == 0)
        {
            return false;
        }
    }

    return true;
}

int n1 = 4;
int m1 = 15;

Console.WriteLine("Задание 1. Ответ:");

for (int i = n1; i <= m1; i++)
{
    if (Prime(i))
    {
        Console.Write($"{i} ");
    }
}

////////////////task2/////////////////////////
static int ReverseNum(int x2)
{
    int revers = 0;

    while (x2 > 0)
    {
        int num = x2 % 10;
        revers = (revers * 10) + num;
        x2 /= 10;
    }

    return revers;
}

int x2 = 1234;
int revers1 = ReverseNum(x2);
Console.WriteLine($"\n\nЗадание 2. Ответ: {revers1}");

////////////////task3/////////////////////////
static double AvgArith(int[] arr1)
{
    if (arr1.Length == 0)
    {
        return 0;
    }

    double sum = 0;

    for (int i = 0; i < arr1.Length; i++)
    {
        sum += arr1[i];
    }

    return sum / arr1.Length;
}

int[] arr1 = {1, 2, 3, 4, 5, 6, 7, 8, 9};
double avg = AvgArith(arr1);
Console.WriteLine($"\nЗадание 3. Ответ: {avg}");

////////////////task4/////////////////////////

static string ReverseWord(string str1)
{
    string[] words = str1.Split(' ');
    Array.Reverse(words);
    return string.Join(" ", words);
}

string str1 = "проверка строки перевёртыша, раз раз, два два";
string revers2 = ReverseWord(str1);
Console.WriteLine($"\nЗадание 4. Ответ: {revers2}");

////////////////task5/////////////////////////

static void ArrWRandNum(int[] arr5, int minRange, int maxRange)
{
    Random random = new Random();
    for (int i = 0; i < arr5.Length; i++)
    {
        arr5[i] = random.Next(minRange, maxRange + 1);
    }
}

int[] arr5 = new int[10];
ArrWRandNum(arr5, 1, 100);

Console.WriteLine($"\nЗадание 5. Ответ: ");

for (int i = 0; i < arr5.Length; i++)
{
    Console.Write(arr5[i] + " ");
}

////////////////task6/////////////////////////

static int FindInd(int[] arr6, int n)
{
    for (int i = 0; i < arr6.Length; i++)
    {
        if (arr6[i] == n)
        {
            return i;
        }
    }
    return -1;
}

int[] arr6 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
int num6 = 8;

int ind6 = FindInd(arr6, num6);

if (ind6 == -1)
{
    Console.WriteLine($"\n\nЗадание 6. Ответ: Число {num6} не обитает в этом массивчике");
}
else
{
    Console.WriteLine($"\n\nЗадание 6. Ответ: Число {num6} обитает в массиве под индексом {ind6}");
}

////////////////task7/////////////////////////

static void PrimeNums(int[] arr7)
{
    for (int i = 0; i < arr7.Length; i++)
    {
        bool Prime = true;
        for (int j = 2; j <= Math.Sqrt(arr7[i]); j++)
        {
            if (arr7[i] % j == 0)
            {
                Prime = false;
                break;
            }
        }
        if (Prime && arr7[i] > 1)
        {
            Console.Write(arr7[i] + " ");
        }
    }
}

int[] arr7 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

Console.WriteLine("\nЗадание 7. Ответ: ");


PrimeNums(arr7);

////////////////task8/////////////////////////

static int FindMaxIndex(int[] arr8)
{
    int maxInd = 0;
    for (int i = 1; i < arr8.Length; i++)
    {
        if (arr8[i] > arr8[maxInd])
        {
            maxInd = i;
        }
    }
    return maxInd;
}

int[] arr8 = new int[] { 5, 2, 8, 1, 4 };

int maxIndex = FindMaxIndex(arr8);

Console.WriteLine($"\n\nЗадание 8. Ответ: Максимальный элемент массивчика {arr8[maxIndex]} обитает в индексе {maxIndex}");

////////////////task9/////////////////////////

Console.WriteLine("\nЗадание 9. Нет ответа: Не понял как делать, если честно, даже гугл не помог");
Console.Clear(); // Очищаем консоль

// 1. Первая группа методов — не принимает никаких аргументов и ничего не возвращают.

void Method1()
{
    Console.WriteLine("Автор...\n");
}

Method1(); // Вызов метода

// 2. Вторая группа методов — принимает какие-то аргументы, но ничего не возвращают.

void Metod2(string msg) // — где void ключевое слово, дальше идентификатор, в скобках указаны какие-то аргументы.
{
    Console.WriteLine(msg); // — оператор, в скобках указан принятый аргумент.
}
Metod2("Текст сообщения\n"); // — где Metod2 является идентификатором, а в скобках указан текст, выводимый в консоли.

void Metod21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
Metod21("Текст\n", 2); // указываем через запятую количество вызовов метода

Metod21(count: 3, msg: "Новый текст\n"); // Явно указывая наименование аргумента, не обязательно писать их по порядку

// ctrl + c - прерывание программы

// Эти две группы — так называемые void методы, которые ничего не возвращают.

// 3. Третья группа методов — может что-то возвращать, но не принимает никаких аргументов.
// Например, может служить для генерации случайных данных.

int Metod3() // - не принимает никакие аргументы
{
    return DateTime.Now.Year; // - обязательное использование оператора return,
}
int year = Metod3(); // - вызываем метод, в левой части используем идентификатор переменной (year)
// и через оператор присваивания (=) кладём нужное значение

Console.WriteLine(year);

// Четвёртая группа методов — что-то принимает (аргументы, данные). И что-то возвращает для дальнейшей работы.

string Metod4(int count, string text)
{
    int i = 0;
    string result = String.Empty;
    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}
string res = Metod4(4, "asdf");
Console.WriteLine(res);

string Metod41(int count, string text) // Тотже метод с циклом for
{
    string result = String.Empty;
    for (int i = 0; i < count; i++) // - вначале ключевое слово, затем инициализация счётчика, после проверка условия и инкремент(увеличение счётчика).
    {
        result = result + text;
    }
    return result;
}
string res1 = Metod41(4, "asdf");
Console.WriteLine(res1);

// Вложеный цикл с for (Вывод таблицы умножения)

for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} * {j} = {i * j}");
    }
    Console.WriteLine();
}

// Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить чёрточками,
// маленькие буквы "к" заменить большими "К",
// а большие "С" маленькими "с".

string text = "— Я думаю, — сказал князь, улыбаясь, — что," +
"ежели бы вас послали вместо нашего милого Винценгероде," +
"вы бы взяли приступом согласие прусского короля." +
"Вы так красноречивы. Вы дадите мне чаю?";

// string s = "qwerty"
// 012345
// s[3] // r

string Replace(string text, char oldValue, char newValue)
{
    string result1 = String.Empty;
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result1 = result1 + $"{newValue}";
        else result1 = result1 + $"{text[i]}";
    }
    return result1;
}
string newText = Replace(text, ' ', '|');

Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'С', 'с');
Console.WriteLine(newText);

// Сортировка массива

int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };
void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}
PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);
void ReverseArray(int[] array)
{
    Array.Reverse(array); // вернёт массив в обратном порядке
    Console.WriteLine(string.Join(" ", array));
}

ReverseArray(arr);
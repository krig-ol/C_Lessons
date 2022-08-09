// void - метод, который ничего не возвращает (Не нужен return)

void FillArray(int[] collection) // Заполняем массив случайными числами

{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col) // Выводим на печать массив случайных чисел
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find) // Ищем индекс элемента массива
{
    int count = collection.Length;
    int index = 0;
    int position = -1; // -1 означет, что элемента с искомым числом нет в массиве
    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break; // Без break будет выводить последний элемент искомого числа, а с break первого
        }
        index++;
    }
    return position;
}

int[] array = new int[10];

FillArray(array);
PrintArray(array);
Console.WriteLine();

// Вывод первого индекса массива СЕМЁРКИ
int pos = IndexOf(array, 7);
Console.WriteLine(pos);

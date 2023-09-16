// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, 
// либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

void Say(string say, bool warning = false, bool breakLine = true)
{
    if (warning) Console.BackgroundColor = ConsoleColor.Red;
    if (breakLine) Console.WriteLine(say);
    else Console.Write(say);
    if (warning) Console.ResetColor();
}
int InsertInt(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}
string InsertStr(string text)
{
    Console.Write(text);
    return Console.ReadLine();
}
string[] GenMas(int m)
{
    string[] mas = new string[m];
    for (int i = 0; i < m; i++)
    {
        mas[i] = InsertStr($"Введите {i + 1}-й элемент массива: ");
    }
    return mas;
}
string[] CutMas(string[] arr)
{
    int j = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length < 4)
        {
            j++;
        }
    }
    string[] mas = new string[j];
    if (j > 0)
    {
        int k = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i].Length < 4)
            {
                mas[k] = arr[i];
                k++;
            }
        }
    }
    return mas;
}
int m = InsertInt("Введите количество элементов первоначального массива: ");
string[] fullArr = GenMas(m);
Say("Создаем массив с элементами короче 4-х символов...", true, true);
string[] cutArr = CutMas(fullArr);
Say($"[{String.Join(",", fullArr)}] => [{String.Join(",", cutArr)}]");
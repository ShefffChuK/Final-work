// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Console.Write("Укажите кол-во эелементов: ");
int size = Convert.ToInt32(Console.ReadLine());

string[] arrayStrings = new string[size];
for (int i = 0; i < size; i++)
{
 Console.WriteLine($"Введите {i+1}-й элемент массива: ");
 string element = Convert.ToString(Console.ReadLine());
 arrayStrings[i] = element;
}

string[] arrayFinal = new string[size];
int lenght = 3;
int position = 0;

for (int j = 0; j < size; j++)
{
 if (arrayStrings[j].Length <= lenght)
    {
 arrayFinal[position] = arrayStrings[j];
 position++;
    }
}

Console.WriteLine();
PrintArray(arrayFinal);



// ===================Метод вывода массива===================
void PrintArray(string[] array)
{
 for (int i = 0; i < array.Length; i++)
    {
 Console.Write(array[i] + " ");
    }
 Console.WriteLine();
}
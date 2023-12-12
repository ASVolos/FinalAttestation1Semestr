
/*Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
лучше обойтись исключительно массивами.
Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []
*/
using System;
public class MainClass
{
    public static void Main()
    {
        // Метод считающий количество элементов <= 3, чтобы понять, какого размера нужен будет новой массив
        int SizeNewArray(string[] array)
        {
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Length <= 3)
                {
                    count++;
                }
            }
            return count;
        }
        // Метод, который заполняет массив элементами с трями и менее символами
        string[] NewArray(string[] oldArray, int size)
        {
            string[] newArray = new string[size];
            int j = 0;
            for (int i = 0; i < oldArray.Length; i++)
            {
                if (oldArray[i].Length <= 3)
                {
                        newArray[j] = oldArray[i];
                        j++;
                }
            }
            return newArray;
        }
        // метод, который запрашивает элементы в консоле и заполняет им массив
        string[] FillArray()
        {
            Console.Write("Imput the size of the array: ");
            int size = Convert.ToInt32(Console.ReadLine());

            string[] newArray = new string[size];

            for (int i = 0; i < size; i++)
            {
                Console.Write("Imput the element of the array: ");
                newArray[i] = Console.ReadLine();
            }
            return newArray;
        }
        void PrintArray(string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
        // Вызов методов
        string[] oldArray = FillArray();   //[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
        int size = SizeNewArray(oldArray);
        PrintArray(NewArray(oldArray, size));
    }
}


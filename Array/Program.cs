using System;

namespace Array
{
    //    Создать массив размерностью N элементов, заполнить его произвольными целыми значениями.
    //Вывести наибольшее значение массива, наименьшее значение массива, общую сумму элементов,
    //среднее арифметическое всех элементов, вывести все нечетные значения.

    class Program
    {
        static void Main(string[] args)
        {

            var arr = Console.ReadLine().Split(new[] { " ", ",", ";" }, StringSplitOptions.RemoveEmptyEntries);

            var array = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                array[i] = Convert.ToInt32(arr[i]);
            }

            int sum = 0, result = 0, maxValue = array[0], minValue = array[0];
             
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > maxValue)
                {
                    maxValue = array[i];
                }
            }

            Console.WriteLine("Максимальное значение массива:" + maxValue);

            for (int i = 1; i < array.Length; i++)
            {
                if (minValue > array[i])
                {
                    minValue = array[i+1];
                }
            }

            Console.WriteLine("Минимальное значение массива:" + minValue);

            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i]; 
            }

            Console.WriteLine("Сумма всех элементов массива:" + sum);

            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }

            result = sum / array.Length;

            Console.WriteLine("Среднее арифметическое всех элементов массива:" + result);

            Console.Write("Нечетные значения массива: ");

            for (int i = 0; i < array.Length; i++)
            {
                if ((array[i] % 2 != 0))
                {
                    Console.Write(array[i] + " ");
                }
            }
        }
    }
}

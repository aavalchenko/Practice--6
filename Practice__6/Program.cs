using System;
using InputOutputLib;

namespace Practice__6
{
    class Program
    {
        static void Main(string[] args)
        {
            Input();
            Console.ReadKey();
        }

        private static void Input()
        {
            Double[] array = new Double[3];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Get.Double("Введите " + i + "-е число последовательности: ");
            }

            Int32 n = Get.Int32("Введите необходимое количество чисел для последовательности, включая уже введённые (N > 3): ", 3);
            Double l = Get.Double("Введите число L, для сравнения: ");
            Int32 m = Get.Int32("Введите необходимое количество чисел, меньше L: ");
            Console.Write("\n{0} {1} {2} ", array[0], array[1], array[2]);

            Next(array[0], array[1], array[2], n, m, l, 3);
        }

        private static void Next(Double a1, Double a2, Double a3, Int32 n, Int32 m, Double l, Int32 count)
        {
            if (count < n)
            {
                Double member = (7 / 3 * a3 + a2) / 2 * a1;
                if (count < m && member < l)
                {
                    Console.Write(member + " ");
                    count++;
                    Next(a2, a3, member, n, m, l, count);
                }
                else
                    Console.Write("\nПостройка последовательности остановлена. Достигнута граница L или построено M чисел < L.");
            }
            else
            {
                Console.Write("\nПостройка последовательности остановлена. Построено N первых элементов последовательсти.");
            }
        }
    }
}

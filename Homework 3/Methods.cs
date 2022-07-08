using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_3
{
    internal class Methods
    {

        public static void Problem1()
        {
            int[] numbers = generateNumbers();
            Reverse(numbers);
            printNumbers(numbers);
        }

        private static int[] generateNumbers()
        {
            int[] numbers = new int[10];
            for (int i = 1; i <= 10; i++)
                numbers[i] = i;
            return numbers;
        }

        private static void Reverse(int[] numbers) {
            int j = numbers.Length - 1;
            for (int i = 0; i < 5; i++)
            {
                int temp = numbers[i];
                numbers[i] = numbers[j];
                numbers[j] = temp;
                j--;
            }
        }

        private static void printNumbers(int[] numbers)
        {
            foreach (int i in numbers)
                Console.WriteLine(i + " ");
        }

        public static int fibbonacci(int index)
        {
            if (index < 2) return 1;
            return fibbonacci(index - 1) + fibbonacci(index - 2);
        }
    }
}

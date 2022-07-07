using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Homework
{
    internal class Problems
    {
        public static void size()
        {
            Console.WriteLine($"byte: {sizeof(byte)}, {byte.MinValue} - {byte.MaxValue}");
            Console.WriteLine($"short: {sizeof(short)}, {short.MinValue} - {short.MaxValue}");
            Console.WriteLine($"int: {sizeof(int)}, {int.MinValue}, {int.MaxValue}");
            Console.WriteLine($"long: {sizeof(long)}, {long.MinValue}, {long.MaxValue}");
            Console.WriteLine($"sbyte: {sizeof(sbyte)}, {sbyte.MinValue}, {sbyte.MaxValue}");
            Console.WriteLine($"ushort: {sizeof(ushort)}, {ushort.MinValue}, {ushort.MaxValue}");
            Console.WriteLine($"uint: {sizeof(uint)}, {uint.MinValue}, {uint.MaxValue}");
            Console.WriteLine($"ulong: {sizeof(ulong)}, {ulong.MinValue}, {ulong.MaxValue}");
            Console.WriteLine($"char: {sizeof(char)}, {char.MinValue}, {char.MaxValue}");
            Console.WriteLine($"float: {sizeof(float)}, {float.MinValue}, {float.MaxValue}");
            Console.WriteLine($"double: {sizeof(double)}, {double.MinValue}, {double.MaxValue}");
            Console.WriteLine($"decimal: {sizeof(decimal)}, {decimal.MinValue}, {decimal.MaxValue}");
        }

        public static void century()
        {
            Console.Write("Input: ");
            byte centuries = byte.Parse(Console.ReadLine());
            ushort years = (ushort) (centuries * 100);
            uint days = (uint) (years * 365);
            uint hours = days * 24;
            uint minutes = hours * 60;
            ulong seconds = minutes * 60;
            ulong milliseconds = seconds * 1000;
            ulong microseconds = milliseconds * 1000;
            ulong nanoseconds = microseconds * 1000;
            Console.WriteLine($"Output: {centuries} Centuries = {years} Years = {days} Days = {hours} Hours = {minutes} Minutes = {seconds} Seconds = {milliseconds} Milliseconds =" +
                $" {microseconds} Microseconds = {nanoseconds} Nanoseconds");
        }

        public static void fizzbuzz()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("Fizzbuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }

        // will overflow because the max for byte is 255.
        // I would write a statement saying that any number counted above the max for
        // byte will be subject to overflow, throw an exception in extreme cases
        public static void overflow()
        {
            int max = 500;
            for (byte i = 0; i < max; i++)
            {
                Console.WriteLine(i);
            }
        }

        public static void guess_random()
        {
            int cnum = new Random().Next(2) + 1;
            Console.Write("Guess the number between 1 and 3 (inclusive): ");
            int guess = int.Parse(Console.ReadLine());
            if (guess == cnum) Console.WriteLine("Correct!");
            if (guess != cnum) Console.WriteLine("Incorrect!");
            Console.WriteLine($"The number was {cnum}, your guess was {guess}, the difference is {guess - cnum}");
        }

        public static void pyramid()
        {
            // decrease space by one, increase stars by two
            int spaces = 10;
            int stars = 1;
            int height = 5;
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < spaces; j++)
                {
                    Console.Write(" ");
                }

                for (int j = 0; j < stars; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
                spaces--;
                stars += 2;
            }
        }

        public static void days_old()
        {
            DateTime a = new DateTime(2000, 4, 29);
            DateTime b = DateTime.Now;
            Console.WriteLine(b.Subtract(a).Days);
        }

        public static void greeting()
        {
            // morning 6 - 12
            // afternoon 1 - 4
            // evening 5 - 9
            // night 9 - 6
            DateTime now = DateTime.Now;
            int hour = now.Hour;
            if (hour >= 5 && hour <= 11)
                Console.WriteLine("Good Morning");
            else if (hour >= 13 && hour <= 17)
                Console.WriteLine("Good Afternoon");
            else if (hour >= 18 && hour <= 21)
                Console.WriteLine("Good Evening");
            else
                Console.WriteLine("Good night");
        }

        public static void countup()
        {
            for (int i = 1; i <= 4; i++)
            {
                int count = 0;
                Console.Write(count + " ");
                while (true)
                {
                    count += i;
                    Console.Write(count + " ");
                    if (count == 24) break;
                }
                Console.WriteLine();
            }
        }

        // ASSGIGNMENT 2: STRINGS AND ARRAYS
        public static void copying_array()
        {
            int[] a = new int[10];
            for (int i = 0; i < 10; i++) a[i] = i;
            int[] b = new int[10];
            for (int i = 0; i < b.Length; i++)
                b[i] = a[i];
            print_int_arr(a);
            print_int_arr(b);
        }

        public static void manage_list()
        {
            List<string> list = new List<string>();
            while (true)
            {
                Console.WriteLine("Enter command (+ item, - item, -- to clear, x to break)):");
                string op = Console.ReadLine();
                char first = op.ToCharArray()[0];
                if (first == '+')
                    list.Add(op.Substring(2));
                else if (op == "--")
                    list.Clear();
                else if (first == '-')
                    list.Remove(op.Substring(2));
                else if (first == 'x')
                    break;
            }
        }

        public static int[] primeNumbers(int start, int end)
        {
            List<int> primes = new List<int>();
            for (int i = start; i <= end; i++)
            {
                bool prime = true;
                for (int j = 2; j < start; j++)
                {
                    if (i % j == 0)
                    {
                        prime = false;
                        break;
                    }
                }
                if (prime) primes.Add(i);
            }
            primes.Remove(0);
            return primes.ToArray();
        }

        public static void rotations(int rotations, params int[] nums) ///////////////
        {
            int[] sum = new int[nums.Length];
            int temp = 0;
            for (int i = 0; i < rotations; i++)
            {
                // read array into sum from last index
                int read = 0;
                int index = nums.Length - 1;
                while (read != nums.Length)
                {
                    sum[read++] += nums[index];
                    index = (index + 1) % nums.Length;
                }
            }
        }

        public static void longestSequnece(params int[] nums)
        {
            List<int> longList = new List<int>();
            List<int> runList = new List<int>();
            int against = nums[0];

            runList.Add(nums[0]);
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] == against)
                {
                    runList.Add(nums[i]);
                    continue;
                }
                   
                if (runList.Count() > longList.Count())
                {
                    foreach (int j in runList)
                        longList.Add(j);
                }
                runList.Clear();
                runList.Add(nums[i]);
            }

            for (int i = 0; i < longList.Count(); i++)
                Console.WriteLine(longList.ElementAt(i) + " ");
        }

        public static int mostFrequentNumber(params int[] nums)
        {
            Dictionary<int, int> frequency = new Dictionary<int, int>();

            // set the values for frequency
            for (int i = 0; i < nums.Length; i++)
            {
                if (frequency.ContainsKey(nums[i]))
                    frequency[nums[i]]++;
                else
                    frequency.Add(nums[i], 1); 
            }

            List<int> keys = new List<int>(frequency.Keys);
            List<int> po = new List<int>();
            int max = 0;

            // get the max count found
            foreach (int key in keys)
            {
                int val = frequency[key];
                if (val > max) max = val;
            }

            // find keys that match that count
            foreach (int key in keys)
            {
                if (frequency[key] == max)
                    po.Add(key);
            }

            foreach (int num in po) {
                Console.WriteLine($"{num} has potential: {max}");
            }

            foreach (int num in po)
            {
                foreach (int onum in nums)
                {
                    if (onum == num)
                    {
                        Console.WriteLine($"{num} comes first.");
                        return num;
                    }
                }
            }

            return -1;
        }

        //STRINGS   
        public static void reverse()
        {
            Console.WriteLine("Enter a sentence to reverse: ");
            string sen = Console.ReadLine();
            for (int i = sen.Length - 1; i > -1; i--)
                Console.Write(sen[i]);
            Console.WriteLine();
        }

        public static void reverseWords() // doesnt quite work
        {
            Console.WriteLine("Enter a sentence to reverse: ");
            string sen = Console.ReadLine();
            string[] words = sen.Split(" ");
            string[] rwords = sen.Split(" ");
            rwords.Reverse();
            StringBuilder b = new StringBuilder();
            for (int i = 0; i < words.Length; i++)
            {
                Replacer r = new Replacer(words[i]);
                r.replace(rwords[i]);
                b.Append(rwords[i]);
                b.Append(" ");
            }
            Console.WriteLine(b);
        }

        public static void test(string str, string re)
        {
            Replacer r = new Replacer(str);
            Console.WriteLine(r.word);
            r.replace(re);
            Console.WriteLine(r.word);
        }

        // WARNING: ONLY ACCOUNTS FOR WORDS AND SPECIAL CHARACTERS IN THE FORM "s-word-s"
        private class Replacer // bug -> replace something with special characters
        {
            internal string word;

            private static string specials = "./:;-()&[]''\\/!?";
            private int beginSpecials;
            private int endSpecials;

            // word should have the special characters contained in them
            internal Replacer(string word)
            {
                this.word = word;

                int i = 0;
                Boolean wordHit = false;
                foreach (char c in word)
                {
                    if (specials.Contains(c))
                    {
                        if (wordHit) endSpecials++;
                        else beginSpecials++;
                    }
                    else if (!wordHit)
                        wordHit = true;
                       
                } 
            }

            // replaces the current non-special portion of the word with the new word. the new word does
            // not need to have the same length. beautiful.
            public void replace(string replaceWith)
            {
                StringBuilder b = new StringBuilder();
                int count = 0;
                int index = 0;

                // special begin
                count = beginSpecials;
                while (count-- != 0)
                    b.Append(word[index++]);

                // word
                b.Append(replaceWith);

                // special end
                count = endSpecials;
                index += replaceWith.Length - 1;
                while (count-- != 0)
                {
                    Console.WriteLine(index);
                    Console.WriteLine(word.Length);
                    b.Append(word[index++]);
                }
                word = b.ToString();   
            }

        }

        public static HashSet<string> palindromeCheck(String str)
        {
            HashSet<string> p = new HashSet<string>();
            for (int l = 2; l <= str.Length; l++)
            {
                for (int i = 0; i < (str.Length - (l - 1)); i++)
                {
                    // check for palindrome
                    string s = str.Substring(i, l);
                    string sr = str.Substring(i, l);
                    sr.Reverse();
                    if (s == sr) p.Add(s);
                }
            }
            return p;
        }

        public static bool urlCheck(string str)
        {
            string[] arr = str.Split("://");
            Console.WriteLine(arr.Length);

            string protocol = "";
            string server = "";
            string resource = "";

            if (arr.Length == 2)
            {
                string[] arr2 = arr[1].Split("/");
                if (arr2.Length == 2)
                    resource = arr2[1];
                server = arr2[0];
                protocol = arr[0];
            } else
            {
                server = arr[0];
            }

            Console.WriteLine($"protocol: {protocol}");
            Console.WriteLine($"server: {server}");
            Console.WriteLine($"resource: {resource}");

            return false;
        }



        private static void print_int_arr<T>(T[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                Console.WriteLine(arr[i].ToString);
        }
    }
}

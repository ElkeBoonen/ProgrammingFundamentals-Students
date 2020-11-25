using System;
using System.Collections.Generic;

namespace Feedback_25_11_2020
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] woorden = "mango orange kiwi kiwi kiwi lemon mandarin apricot pineapple grapefruit banana apricot lemon lime apricot kiwi orange".Split(' ');

            for (int i = 0; i < woorden.Length; i++)
            {
                for (int j = 0; j < woorden.Length - 1 - i; j++)
                {
                    if (String.Compare(woorden[j], woorden[j + 1]) > 0)
                    {
                        string tijdelijk = woorden[j];
                        woorden[j] = woorden[j + 1];
                        woorden[j + 1] = tijdelijk;
                    }
                }
            }

            foreach (var item in woorden)
            {
                Console.Write(item + " ");
            }

            //https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2?view=net-5.0
            Dictionary<string, int> fruit = new Dictionary<string, int>();
            foreach (var item in woorden)
            {
                if (fruit.ContainsKey(item)) fruit[item]++;
                else fruit[item] = 1;
            }


            KeyValuePair<string, int>[] arrayVanKeyValues = new KeyValuePair<string, int>[fruit.Count];
            int index = 0;
            foreach (var item in fruit)
            {
                arrayVanKeyValues[index] = new KeyValuePair<string, int>(item.Key, item.Value);
                index++;
            }

            for (int i = 0; i < arrayVanKeyValues.Length; i++)
            {
                Console.WriteLine(arrayVanKeyValues[i].Key + " " + arrayVanKeyValues[i].Value);
            }


            foreach (var item in fruit)
            {
                Console.WriteLine(item);
            }

            int grootste = 0;
            string woord = "";

            foreach (var item in fruit)
            {
                if (item.Value > grootste)
                {
                    grootste = item.Value;
                    woord = item.Key;

                }
            }
            Console.WriteLine(woord + " komt " + grootste + " keer voor!");

            //kiwi --> iwikay

            //https://docs.microsoft.com/en-us/dotnet/api/system.string?view=net-5.0
            string sub1 = woord.Substring(1);
            string sub02 = woord.Substring(0, 2);
            Console.WriteLine(sub1 + " " + sub02);

            int[][] jagged = new int[3][];

            jagged[0] = new int[] { 1, 2, 3 };
            jagged[1] = new int[] { 1, 2, 0 };
            jagged[2] = new int[] { 4, 2, 3 };

            int[] sommen = new int[3];

            for (int i = 0; i < jagged.GetLength(0); i++)
            {
                for (int j = 0; j < jagged[i].Length; j++)
                {
                    sommen[j] += jagged[i][j];
                }
            }

            foreach (var item in sommen)
            {
                Console.WriteLine(item);
            }

        }
    }
}

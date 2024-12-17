using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CollectionPractices
{
    internal class GenericCollections
    {
        public static void ListFunction()
        {
            List<string> list = new List<string>();
            list.Add("Apple");
            list.Add("Net");
            list.Add("Cuop");
            list.Add("Elephant");

            foreach (string s in list)
            {
                Console.WriteLine(s);
            }
        }

        public static void DictionaryFunction()
        {
            Dictionary<char, int> d = new Dictionary<char, int>();
            d.Add('a', 243);
            d.Add('h', 876);
            d.Add('k', 78);
            d.Add('o', 234);

            foreach (KeyValuePair<char, int> keyValue in d)
            {
                Console.WriteLine(keyValue.Key + "    " + keyValue.Value);
            }
        }


        public static void SortedListFunction()
        {
            SortedList<int, char> sl = new SortedList<int, char>();
            sl.Add(12, 'a');
            sl.Add(22, 'v');
            sl.Add(11, 'g');
            sl.Add(32, 'r');

            foreach (KeyValuePair<int, char> element in sl)
            {
                Console.WriteLine(element.Key + "    " + element.Value);
            }
        }

        public static void StackFunction()
        {
            Stack<double> s = new Stack<double>();
            s.Push(23.453);
            s.Push(435.09);
            s.Push(1323);
            s.Push(6.5);
            s.Push(20.09);

            s.Pop();

            foreach (double element in s)
            {
                Console.WriteLine(element);

            }

        }


        public static void QueueFunction()
        {
            Queue<string> q = new Queue<string>();
            q.Enqueue("fdgfdv");
            q.Enqueue("j");
            q.Enqueue("Dog");
            q.Enqueue("34.555564");



            q.Dequeue();

            foreach (string element in q)
            {
                {
                    Console.WriteLine(element);
                }
            }
        }
    }
}

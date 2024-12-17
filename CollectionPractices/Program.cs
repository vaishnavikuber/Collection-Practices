using System;

namespace CollectionPractices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------Collections--------------");
            //NonGenericCollection.ArrayListFunction();

            //NonGenericCollection.HashTableFunction();

            //NonGenericCollection.SortedListFunction();

            //NonGenericCollection.StackFunction();

            //NonGenericCollection.QueueFunction();

            //GenericCollections.ListFunction();

            GenericCollections.DictionaryFunction();

            GenericCollections.SortedListFunction();

            GenericCollections.StackFunction();

            GenericCollections.QueueFunction();
            Console.ReadLine();
        }
    }
}

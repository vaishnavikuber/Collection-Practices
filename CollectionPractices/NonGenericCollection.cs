using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CollectionPractices
{
    internal class NonGenericCollection
    {
        public static void ArrayListFunction()
        {
            ArrayList al = new ArrayList();
            al.Add(10);
            al.Add("vaishnavi");
            al.Add('c');
            al.Add(29.67);
            al.Add(DateTime.Now);

            foreach(var element in al)
            {
                Console.WriteLine(element);
            }
        }


    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    internal class ArraylistConcept
    {

        public static void aarlistBasicConcept()
        {

            ArrayList l1 = new ArrayList();

            //Add items in ArrayList 

            l1.Add("Shivam");
            l1.Add('A');
            l1.Add(3);
            l1.Add(5.9f);

            //Total NumberOf elemnts in arraylist 
            Console.WriteLine("Toal Number Of elemnts " + l1.Count);


            foreach (var item in l1)
            {
                Console.WriteLine(item);
            }


            l1.Remove('A');
            l1.Insert(2, "Gautam");


        }
    }
}

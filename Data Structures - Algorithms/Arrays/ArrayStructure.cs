using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_and_Algorithms.Arrays
{
    public class ArrayStructure
    {
        private string[] array = { "a", "b", "c", "d", };

        public void introduction()
        {
            Console.WriteLine("\n-----Welcome to the Array Data Structure-----");
            Console.WriteLine("Building everything in C# while the video is in JavaScript.");
            foreach (var item in array)
                Console.Write($"{item} ");
            Console.WriteLine("\nValue found at array[2]: " + array[2]);

            //he is talking about adding and removing from an array.
            //We can't modify the size of the array once it is built so this is not possible c#... use List instead.

            //Just want to see if I can come up with a way of doing it anyways.
            Console.WriteLine("\n-----Can I come up with a way to add to another array based on first one?-----");
            string[] test;
            test = new string[array.Length + 1];

            foreach (var item in array)
                array.CopyTo(test, 0);
            //0(n)

            var lastIndex = test.Length - 1; //0(1)
            test[lastIndex] = "e"; //0(1)

            foreach (var item in test)
                Console.Write($"{item} ");
            Console.WriteLine("\n-----Yes I can. LoL!-----");
            //0(n)

            //Big0(n)
        }
    }
}
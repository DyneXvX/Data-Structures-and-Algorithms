using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures___Algorithms.GoogleInterview
{
    public class InterviewQuestion
    {
        // video found at: https://www.youtube.com/watch?v=XKu_SEDAykw
        // can I solve this before they do in c# instead??

        // interviewer ask for a sum of 8 from these two collection of numbers.
        // [1,2,3,9]
        // [1,2,4,4]

        public void interview()
        {
            Console.WriteLine("\n-----Google Interview Question from YouTube-----");
            int[] collection01 = { 1, 2, 3, 9 };
            int[] collection02 = { 1, 2, 4, 4 };
            var number01 = 0;
            var number02 = 0;

            for (int i = 0; i < collection02.Length; i++)
            {
                number01 = collection02[i];
                for (int j = collection02.Length - 1; j >= 0; j--)
                {
                    number02 = collection02[j];
                    if (number01 + number02 == 8)
                    {
                        Console.WriteLine(" " + number01 +
                            " + " + number02 +
                            " is equal to 8.");
                        break;
                    }
                }
            }

            //he offered a solution like this first. but said this is not the best way to do it.
            //she stated yes he is correct but prehaps something faster??
            //binary search??? I need more experience and to learn better ways of doing the same operations.
            //very happy I was able to build this off the top of my head however. :)
        }

        public bool interview02()
        {
            Console.WriteLine("\n-----Interview Question 2-----");
            // Given 2 arrays, create a function that lets a user know (true/false) whether these two array contain any common items.

            string[] array01 = { "a", "b", "c", "x" };
            string[] array02 = { "z", "y", "i" };

            for (int i = 0; i < array01.Length; i++)
            {
                for (int j = 0; j < array02.Length; j++)
                {
                    if (array01[i] == array02[j])
                    {
                        return true;
                    }
                }
            }
            return false;

            //Big0(n^2) not the best but the first thing that came to my mind.
            //keep in mind if I brought in two different values from the program.cs file instead of buiding them here, I could convert this to Big0(a * b) instead.
            //public bool interview02(array1, array2) <--> Something like this.
        }

        public bool interveiew02Answer(string[] arr1, string[] arr2)
        {
            Console.WriteLine("\n-----Better Way to solve the interview question.-----");
            List<string> map = new List<string>();

            //I setup null checks becuase this was driving me nuts when thinking of ways to break this.
            if (arr1 != null)
            {
                for (var i = 0; i < arr1.Length; i++)
                {
                    map.Add(arr1[i]);
                }
            }
            else
            {
                return false;
            }
            //O(a)

            if (arr2 != null)
            {
                for (var j = 0; j < arr2.Length; j++)
                {
                    if (map.Contains(arr2[j]))
                    {
                        return true;
                    }
                }
                return false;
            }
            return false;
            //O(b)

            //Therefore this setup is O(a + b) Time Complexity
            //O(n) Memeory complexity becuase I created the map to take in the first array.
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_and_Algorithms
{
    public class Big0
    {
        //How many operations are required? 

        public bool findNemo(string[] name)
        {
            for(var i = 0; i < name.Length; i++)
            {
                if (name[i] == "nemo")
                {
                    Console.WriteLine("Found Nemo on the index: " + i);                    
                    return true;
                }
                
            }
            Console.WriteLine("We didn't find nemo");
            return false;
        }

        //One for each name in the string array. Therefore we have a 0(n) - also known as linear time.
    }
    
}

using System.Security.Cryptography.X509Certificates;

namespace Data_Structures_and_Algorithms.Big0
{
    public class Big0
    {
        //How many operations are required?

        public bool findNemo(string[] name)
        {
            Console.WriteLine("-------Finding Nemo Example-------");
            for (var i = 0; i < name.Length; i++)
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

        public void logFirstTwoBoxes(int[] boxes)
        {
            Console.WriteLine("\n-------Boxes Example------");
            Console.WriteLine(boxes[0]); // 0(1)
            Console.WriteLine(boxes[1]); // 0(1)
                                         //there we will always have 0(2) -> but for whatever reason we don't say 0(2) we say 0(1) - also know as Constant Time.
        }

        //Figure out the Big 0 of this
        public int exampleChallenge(int number)
        {
            var a = 10; // 0(1)
            a = 50 + 3; // 0(1)

            for (var i = 0; i < number; i++) // 0(n)
            {
                //anotherFunction(); //0(n)
                //var stranger = true; //0(n)
                a++; //0(n)
            }
            return a; //0(1)
        }

        // 3 steps + 4n
        //Therefor Big 0(3 + 4n) or Big0(n) <-- simple version

        //What is the big0 of this???
        public void arrayPairs(int[] boxes)
        {
            Console.WriteLine("\n------What Boxes do we have??-----");
            foreach (var box in boxes)
                Console.WriteLine("Box: " + box);

            Console.WriteLine("\n-----Now print every pair of those boxes possible.-----");
            var totalcount = 0;
            for (var i = 0; i < boxes.Length; i++)
            {
                for (var j = 0; j < boxes.Length; j++)
                {
                    if (boxes[i] != boxes[j])
                    {
                        Console.WriteLine("Box " + boxes[i] + " & Box " + boxes[j]);
                        totalcount++;
                    }
                }
            }
            Console.WriteLine("The total number of pairs is " + totalcount + " box pairs.");
        }

        // A loop in a loop... So we are looking at loop 1 = Big0(n) + loop 2 which equals Big0(n) as well. So now we have Big0(n^2) <-- Quadratic Time
        // This is really bad by the way.

        public void rules()
        {
            Console.WriteLine("\n--------Big0 Rules--------");
            Console.WriteLine("Rule 1: Worst Case");
            Console.WriteLine("Always look at the Worst Case. If you have big0(1) and big0(n) in the same method. The Big0 is big0(n)");
            Console.WriteLine("\nRule 2: Remove Constants");
            Console.WriteLine("Big0(1 + n/2 + 100) =  Big0(n)");
            Console.WriteLine("\nRule 3: Different terms for inputs");
            Console.WriteLine("Think of the boxes method. What if there were two boxes? Therefore int[]boxes, and int[]moreBoxes");
            Console.WriteLine("\nRule 4: Drop Non Dominants");
            Console.WriteLine("So Big0(n + n^2) would in fact become Big(n^2)");
        }

        public void goodCode()
        {
            Console.WriteLine("\n-----What is good code?-----");
            Console.WriteLine("Readable Code is good code.");
            Console.WriteLine("Good code is also Scalable");
            Console.WriteLine("     1. Speed and time.");
            Console.WriteLine("     2. How much memory does your program use?");
            Console.WriteLine("Remember the 3 pillers of programming");
            Console.WriteLine("     1. Readable");
            Console.WriteLine("     2. Memory - or space complexity");
            Console.WriteLine("            a. the heap and the stack");
            Console.WriteLine("     3. Speed - or time complexity");
            Console.WriteLine("Remember the trade off between Memory and Speed... Want it faster? Might need more memory... ");
        }

        public void spaceComplexity(int[] numbers)
        {
            Console.WriteLine("\n-----Space Complexity question-----");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("Space Complexity is equal too.....");
            }
            Console.WriteLine("In this example it is just 0(1) as I have only crated the i in the loop...");
        }

        //find the first tweet and the nth tweet...
        public void exercise()
        {
            string[] tweets = { "Hello", "Whats up!", "Hello World" };

            var firstTweet = tweets[0]; //0(1)
            var lastTweets = tweets.Length - 1; // 0(1)

            var tweetData = new List<tweetData>
            {
                new tweetData
                {
                    tweet = "Hello",
                    date = DateTime.Now,
                },
                new tweetData
                {
                    tweet = "Whats up!",
                    date = DateTime.Today.AddYears(-10)
                }
            };

            foreach (var item in tweetData)
            {
                Console.WriteLine("The tweet is: " + item.tweet + "\n" +
                    "The tweets date was on: " + item.date);
            }
            Console.WriteLine("For items like this, I would need to write a loop in loop to find a certain tweet. Therefore this becomes 0(n^2).... Not great");
        }

        public class tweetData
        {
            public string? tweet;
            public DateTime? date;
        }
    }
}
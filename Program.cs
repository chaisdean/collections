using System;
using System.Collections.Generic;

namespace collections_practiceNEW
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int[] arrIntegers = new int[10]{0,1,2,3,4,5,6,7,8,9};
            string[] arrNames = new string[]{"Tim", "Martin", "Nikki", "Sara"};
            bool[] alternateBool = new bool[10];
            for (int i=0; i < 10; i+=2)
            {
                alternateBool[i] = true;
            }
           

            int[,] multTable = new int[10,10];
            for(int x = 0; x < 10; x++)
            {
                for(int y = 0; y < 10; y++)
                {
                    multTable[x,y] = (x + 1) * (y + 1);
                }
            }

            for (int x = 0; x < 10; x++)
            {
                string display = "[";
                for(int y = 0; y < 10; y++)
                {
                    display += multTable[x,y] + ",";
                    if (multTable[x,y] < 10)
                    {
                        display += " ";
                    }
                }
                display += "]";
                Console.WriteLine(display);
                
                }

                List<string> iceCream = new List<string>();
                iceCream.Add("Vanilla");
                iceCream.Add("Chocolate");
                iceCream.Add("Mint Chocolate Chip");
                iceCream.Add("Cake Batter");
                iceCream.Add("Strawberry");
                for (var i = 0; i < iceCream.Count; i++)
                {
                    Console.WriteLine("The different flavors i love are: {0}", iceCream[i]);
                } 
                iceCream.Remove("Mint Chocolate Chip");
                for (var i = 0; i < iceCream.Count; i++)
                {
                    Console.WriteLine("The different flavors i love are: {0}", iceCream[i]);
                } 

                Dictionary<string, string> userInfo = new Dictionary<string, string>();
                Random rand = new Random();
                foreach(string name in arrNames)
                {
                    userInfo[name] = iceCream[rand.Next(iceCream.Count)];
                }
                foreach(KeyValuePair<string,string> info in userInfo)
                {
                    Console.WriteLine(info.Key + " " + info.Value);
                }
                
                Console.WriteLine("something");
            }   
        
    }             
    

}


using System;
using System.Collections.Generic;

namespace Collections_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] array3 = new int[] {0,1,2,3,4,5,6,7,8,9};
            string[] names = new string[] {"Tim","Martin", "Nikki", "Sara"};
            bool[] boolArray = new bool[10];
            for(int i = 0; i < 10; i ++){
                if (i%2 == 0){
                    boolArray[i]=true;
                }
                else{
                    boolArray[i]=false;
                }
            }


            List<string> flavors = new List<string>();
            flavors.Add("strawberry");
            flavors.Add("chocolate");
            flavors.Add("espresso");
            flavors.Add("mint");
            flavors.Add("blackberry");
            flavors.Add("carmel");
            int c = flavors.Count;
            Console.WriteLine(c);
            Console.WriteLine(flavors[2]);
            flavors.Remove(flavors[2]);
            int nc = flavors.Count;
            Console.WriteLine(nc);

            Dictionary<string,string> dict = new Dictionary<string,string>();
            foreach(string name in names)
            {
                dict.Add(name, null);
            }
            foreach(KeyValuePair<string,string> entry in dict){
            Console.WriteLine(entry.Key);
            }
            foreach(KeyValuePair<string,string> name in dict){
            Random rand = new Random();
            foreach(string name in names)
            {
                dict[name] = flavors[0];
            }


            }




        }
    }
}

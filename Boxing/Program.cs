using System;
using System.Collections.Generic;
namespace Boxing
{
    class Program
    {
        static void Main(string[] args)
        {
            List<object> stuff = new List<object>();
            stuff.Add(7);
            stuff.Add(28);
            stuff.Add(-1);
            stuff.Add(true);
            stuff.Add("chair");

            int sum= 0;
            foreach(var thing in stuff){
                Console.WriteLine(thing);
                if(thing is int){
                    sum += (int)thing;
                }
            }
            Console.WriteLine(sum);
        }
    }
}

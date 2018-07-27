using System;

namespace Puzzles
{
    class Program
    {
        static int [] randomarrary(){

            int [] arr = new int [10];
            Random rand = new Random();
            int sum = 0;
            for(int i = 0; i < 10; i++){
                arr[i] = rand.Next(5,25);
                // System.Console.WriteLine(arr[i]);
                sum += i;
            }
            int min = arr[0];
            int max = arr[0];
            foreach(int num in arr){
                if (num > max){
                    max = num;
                }
                if (num < min){
                    min = num;
                }
            }
            System.Console.WriteLine("Min ={0}, Max = {1}, Sum ={2}", min, max, sum);
            return arr;
        }

        static int coinflip(){
            System.Console.WriteLine("Tossing a Coin!");
            Random rand = new Random();
            int toss = rand.Next(1,3);
            if(toss == 1){
                System.Console.WriteLine("heads");
            }
            else{
                System.Console.WriteLine("tails");
            }
            return toss;
        }

        static double multipleflip(int num){
            int heads = 0;
            for(int i = 1; i < num +1; i++ ){
                int result = coinflip();
                if(result == 1){
                    heads ++;
                }
            }
            double ratio = (double)heads/(double)num;
            System.Console.WriteLine(ratio);
            return ratio;
        }
        static string[] names(){




        }
        static void Main(string[] args)
        {
            // randomarrary();
            // coinflip();
            // multipleflip(15);
        }
    }
}

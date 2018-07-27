using System;
using System.Collections.Generic;

namespace basic13
{
    class Program
    {
        static void print1to255(){
            for(int i = 1; i < 256; i++){
                System.Console.WriteLine(i);
            }
        }

        static void odd1to255(){
            for(int i = 1; i < 256; i++){
                if(i%2 != 0){
                    System.Console.WriteLine(i);
                }
            }
        }

        static void printsum(){
            int sum = 0;
            for( int i = 0; i < 256; i ++){
                sum += i; 
                System.Console.WriteLine("New number: {0} Sum: {1}", i, sum);
            }
        }
        static void looparray(int[] arr){
            foreach(var i in arr){
                System.Console.WriteLine(i);
            }
        }

        static void findmax(int[] arr){
            var max = 0;
            foreach(var i in arr){
                if(max < i){
                    max = i;
                }                
            }
            System.Console.WriteLine(max);
        } 
        static void average(int []arr){
            var sum= 0;
            foreach(var i in arr){
                sum += i;
            }
            var average = (sum/arr.Length);
            System.Console.WriteLine(average);
        }

        static void arraywithodds(){
            List<int> y = new List<int>();
            for(int i = 1; i < 256; i ++){
                if(i%2 != 0){
                    y.Add(i);
                }
            }
            System.Console.WriteLine(y.ToArray());
        }
        static void greaterthany(int y, int[] arr){
            int count = 0;
            for(int i = 0; i < arr.Length; i++){
                if( y < arr[i]){
                    count ++;
                }
            }
            System.Console.WriteLine(count);
        }

        static void squarevalues(int [] arr){
            for(int i = 0; i < arr.Length; i ++){
                arr[i] *= arr[i];
            }
            System.Console.WriteLine(arr);

        }

        static void negativezeros( int [] arr){
            for(int i = 0; i < arr.Length; i++){
                if(arr[i] < 0){
                    arr[i] = 0;
                }
                System.Console.WriteLine(arr[i]);
            }
        }
        static void minMaxAvg(int[] arr{
        int min = arr[0];
        int max = arr[0];
        int sum = arr[0];
        int count = arr[0];
        for(int i = 1; i < arr.Length; i++){
            if(arr[i] < min){
                min = arr[i];
                }
                else if(arr[i] > max){
                    max = arr[i];
                }
                sum += arr[i];
                count ++;
        }
        float avg = (float)sum/(float)count;
        System.Console.WriteLine("Max is {0}", max);
        System.Console.WriteLine("Min is {0}", min);
        System.Console.WriteLine("Avg is {0}", avg);
        }
        static void numToString(object[] arr){
            for(int i = 0; i < arr.Length; i++){
                if(arr[i] is int){
                    if((int)arr[i] < 0){
                        arr[i] = "Dojo";
                    }
                }
                System.Console.WriteLine(arr[i]);
            }
        }
        
        
        static void Main(string[] args)
        {
            print1to255();
            odd1to255();
            printsum();
            looparray(new int[] {1,3,5,7,9});
            findmax( new int [] {-1, 3, 0, 83, -57 });
            average( new int [] {-1, 3, 0, 83, -57 });
            arraywithodds();
            greaterthany(3, new int [] {1,3,5,7});
            squarevalues(new int [] {1,5,10,-2});
        }
    }
}

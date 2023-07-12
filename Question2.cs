using System;
namespace Question2{
    class SortedNumbers {
        public static void sort(int a,int b,int c){
            
            if(a>=b&&a>=c){
                Console.WriteLine($"first number is {a}");
                if (b >= c){
                    Console.WriteLine($"second number is {b},'\n' third number is {c}.");
                }
                else{
                    Console.WriteLine($"third number is {c}, '\n' second number is {b}.");
                }

            }
            else if(b>=c&&b>=a){
                Console.WriteLine($"first number is {b}");
                if (a >= c){
                    Console.WriteLine($"second number is {a},\n");
                    Console.WriteLine($"third number is {c}\n, ");
                }
                else{
                    Console.WriteLine($"third number is {a},\n"+$"second number is {c}");
                }
                

            }
            else{
                Console.WriteLine($"first number is {c}");
                if (a > b){
                    Console.WriteLine($"second number is {a}, \n" + $"third number is {b}");
                }
            }
            

        }
}
}
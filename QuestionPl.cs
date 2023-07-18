using System;
namespace Zig
{
    class PatternConcave{
        public static void printPattern(int n){

           int st=n-1;
           int i=0;
           while(i<(2*n-1)){
            int j=0;
            while(j<=st){
                Console.Write("*");
                j++;
            }
            if(i<n&&st!=0){
                st--;
            }
            else{
                st++;
            }
            Console.WriteLine();
            i++;
           }
        }
    }
    
}
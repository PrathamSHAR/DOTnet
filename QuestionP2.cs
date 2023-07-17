using System;
namespace PatternPyra{
    class Triangle{
        public  static void Patt(int n){
            int sp=n-1;
            int s=1;
            for(int i=0; i<n;i++){
                for(int j=0;j<sp;j++){
                    Console.Write(" ");
                }
                for(int k=0;k<s;k++){
                    Console.Write("*");
                }
                sp--;
                s+=2;
                Console.WriteLine();
            }
        }
    }
}
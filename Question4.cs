using System;
namespace Question4{
    class Factorial{
        public static int fact(int n){

            if (n ==0) return 1 ;
            else if(n<0){
                return -1;
            }
            else {
                int f=n*fact(n-1);
                return f;

            }

        }
    } 
}
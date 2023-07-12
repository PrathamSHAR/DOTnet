using System;
namespace Question3{
    class ReverseNumber{
        public static int Reverse(int n){
            int rev=0;
            while(n>0){
                int r=n%10;
                rev=rev*10+r;
                n/=10;

            }
            return rev;
        }
    }
}
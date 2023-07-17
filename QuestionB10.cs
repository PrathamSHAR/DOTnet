using System;
namespace GCD{
    class Number{
        public static int diviser(int a ,int b){
            int x;
            if(a>b){
            x=b;
            }
            else{
                x=a;
            }
            int gcd=1;

            for(int i=1;i<=x;i++){
                if(a%i==0&&b%i==0){
                    gcd=i;
                }
            }
            
            return gcd;
        }
    }
}
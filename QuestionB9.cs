using System;
namespace Prime
{
    class Number{
        public static void range(int a,int b){
            for(int i=a;i<=b;i++){
                if(isPrime(i)){
                    Console.Write(i+",");
                }
            }
            
        }
        public static bool isPrime(int n){
        for(int i=2;i<n;i++){
            if(n%i==0){
                return false;
            }
        }
        return true;
        }
    }
    
}
using System;
namespace Pattern1{
    class Triangle{
        public static void tfirst(int n){
            for(int i=n;i>0;i--){
                for(int j=1;j<=i;j++){
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
        
    }
}
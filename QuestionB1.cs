using System;

namespace Series{
    class fibonacci{
        public static void fibo(int n){
            int s=0;
            int g=1;
            for(int i=0;i<n;i++){
                Console.Write(s+",");
                s=s+g;
                g=s-g;

                            }
        }
    }
}

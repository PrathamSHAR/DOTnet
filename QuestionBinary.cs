using System;
namespace Binary{
    class Search{
        
        public static int doSearch(int []a,int n){
            
         int st=0;
         int l=a.Length;
         int mid;
         Console.WriteLine("pass");
         while(st<=l){
            
             mid=(st+l)/2;
            if(a[mid]==n){
                return mid;
            }
           else if(n<a[mid]){
                 l=mid-1;
            }
            else {
                st=mid+1;
            }
         }
         return -1;

        }
    }
}
using System;
namespace Question1
{
    class Goods_amount
{
    public static double calculateDiscount(){
        Console.WriteLine("Enter the number of items:");
         int amount=Convert.ToInt32(Console.ReadLine());
        
        if (amount>=1000){
            return 20*(double)amount/100; //discount for more than or equal to one
        }
        else if(amount>=500&&amount<1000){
            return 10*(double)amount/100;
        }
        else if(amount>=200&&amount<500){
            return 4*(double)(amount)/100;
        }
        return 1.5*(double)amount/100;
    }
    // static void Main(string[] args){
    //     int amount=Convert.ToInt32(Console.ReadLine());
    //       calculateDiscount(amount);
    // }
}    
}
// See https://aka.ms/new-console-template for more information
using System;

// namespace HelloWorld
// {
//   class Program
//   {
//     static void Main(string[] args)
//     {
//       const int com=4;
//       string txt = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
// Console.WriteLine("The length of the txt string is: " + txt.Length);
//       Console.WriteLine(Math.Max(5, 10));
//       Console.WriteLine("Enter your age:");
//     int Age =Convert.ToInt32( Console.ReadLine());
//       Console.WriteLine("Your age is: " + Age);
      
//       int cr=10000000;
//       string ? input=Console.ReadLine();
//       Console.WriteLine($"Hello{com} World!"+(com+cr));
//       Console.WriteLine(4+3); 
//       Console.Write("Enter your name: ");
      
//     //   Console.ReadKey();
//     Console.WriteLine(input);
      



//     }
//   }
// }




// namespace palindrome
// {
//   class Gazab
//   {
//   static void Main(string [] args){
//     // int number=123;
//     Console.WriteLine("Enter a Number to be checked");
//     int number=Convert.ToInt32(Console.ReadLine());
//     if (number < 0 || ((long)(number)!= Math.Abs((double)number))){
//         Console.WriteLine("Not palindrome");
//         return;
//     }
//     else{
//       int copy=number;
//       int rev=0;
//       while(copy>0){
//         int r=(copy%10);
//         rev=rev*10+r;
//         copy/=10;
//       }
//       if(number==rev){
//         Console.WriteLine($"{number} is a Palindrome",number);//interpolations
//       }
//       else{
//         Console.WriteLine($"{number} and its reverse are not equal.Thus not a palindrome",number);
//       }
//     }

//   List<string> names=new List<string>{"console","classlib","webapp,rajor","winforms","WPF"};
//   foreach(var item in names){
//     string[] words =item.Split(",");
//     Console.WriteLine(item);
//      for(int i=words.Length-1;i>=0;--i){
//       Console.Write("{0}",words[i]);

//      }
//   }

// }
// }
// }
// Console.WriteLine("Hello, World!");


Console.WriteLine("Choose the Questions option A Discount");
Console.WriteLine("Option B for sorted 3 numbers");

string ? st=Console.ReadLine();
if(st.CompareTo("A")==0){
    double Disc=Question1.Goods_amount.calculateDiscount();
    Console.WriteLine($"You Saved {Disc} rupees");
}
else if (st=="B"){
  Console.WriteLine("Enter the numbers separated by space:");
            int a=Convert.ToInt32(Console.ReadLine());
            int b=Convert.ToInt32(Console.ReadLine());
            int c=Convert.ToInt32(Console.ReadLine());
  Question2.SortedNumbers.sort(a,b,c);
}
else if(st=="C"){
  Console.WriteLine("Enter a number");
  int num=Convert.ToInt32(Console.ReadLine());
  int rev=Question3.ReverseNumber.Reverse(num);
  Console.WriteLine($"Reverse of the number={rev}");
}
else if(st=="D"){
  Console.WriteLine("Enter a number for calculating factorial");
  int n=Convert.ToInt32(Console.ReadLine());
  int factorial=Question4.Factorial.fact(n);
  Console.WriteLine($"Factorial of the number={factorial}");

}

// double Discount=Question1.Goods_amount.calculateDiscount();
// Console.WriteLine($"You Saved {Discount} rupees");




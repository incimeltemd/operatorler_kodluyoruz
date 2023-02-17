using System;

namespace operatorler
{
class Program
{

public static void Main()
{

    //atama operatörü---/ = 
    int sayi = 5;
    string metin = "kelime5";
    //artimetik operatörler---/ +-/*%
    int sayi1 = 4;
    int sayi2 = 5;
    int islem = sayi1 + sayi2;

    //mantıksal operatörler---/ && -||-! 

    if(sayi1<sayi2 || sayi1>sayi2)
    Console.WriteLine("islem tamam");

     //karşılaştırma operatörleri---/ <> <= >= == !=
   if(sayi1<=sayi2)
     Console.WriteLine("küçüktür");
}   

}

}



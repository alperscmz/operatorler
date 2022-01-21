using System;
namespace operatorler
{
    class program
    {
        static void Main(string[] args)
        {
            //atama ve işlemli atama
int x=3;
int y=5;
y=y+2;
Console.WriteLine(y);
Console.WriteLine(x);
y+=2;
Console.WriteLine(y);
y/=1;
Console.WriteLine(y);
x*=2;
Console.WriteLine(x);

//mantıksal operatörler ||, &&,!
bool isSuccess=true;
bool isCompleted=false;

if(isSuccess && isCompleted)
Console.WriteLine("Perfect!");

if(isSuccess || isCompleted)
Console.WriteLine("Great!");

if(isSuccess && !isCompleted)
Console.WriteLine("Fine!");

//ilişkisel Operatörler

int a=4;
int b=5;
bool sonuc=a<b;
Console.WriteLine(sonuc);
sonuc=a>b;
Console.WriteLine(sonuc);
sonuc=a>=b;
Console.WriteLine(sonuc);
sonuc=a<=b;
Console.WriteLine(sonuc);
sonuc=a==b;
Console.WriteLine(sonuc);
sonuc=a!=b;
Console.WriteLine(sonuc);

Console.WriteLine("********Aritmetik Operatörler********");
//aritmetik operatörler

int sayi1=8;
int sayi2=4;
int sonuc3=sayi1/sayi2;
Console.WriteLine(sonuc3);
sonuc3=sayi1+sayi2;
Console.WriteLine(sonuc3);
sonuc3=sayi1*sayi2;
Console.WriteLine(sonuc3);
sonuc3=sayi1++;
Console.WriteLine(sayi1);

int sonuc5=20%6;
Console.WriteLine(sonuc5);

        }
    }
}   

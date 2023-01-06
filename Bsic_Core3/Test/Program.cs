using P;
using PRO;
using Single;
using Bk;
Person p = new Person();


Console.WriteLine("name "+p.FirstName+" "+p.LastName+" Id ="+p.Id);


p.Id = 7;
p.FirstName ="hello";
p.LastName = "hi";

Console.WriteLine("name "+p.FirstName+" "+p.LastName+" Id ="+p.Id);


p.Display("cpp","csk","c","com");
int num1=1;
int num2=2;
Console.WriteLine("befor num1= "+num1+"num2 "+num2);// 1 2


p.Valuebyref(ref num1, ref num2);

Console.WriteLine("after num1= "+num1+"num2 "+num2);// 2 1

float area = 0;
float circumference = 0;

Console.WriteLine(" befor area={0},circumference={1}",area,circumference);//0 0

p.ValuebyOut(1.1f,out area,out circumference);

Console.WriteLine(" after area{0},circumference{1}",area,circumference);// 1.1 2.2

Product [] arr = {
    new Product("goldy",10),
    new Product("parly",30),

    new Product("britinia",40),

    new Product("goodday",60)


};

foreach( Product PP in arr)
{
    Console.WriteLine(PP); //pro 
}

SingleTon St = SingleTon.NewObject("Person","Earth");

SingleTon.Display(St);// person Earth

Book Myb = new Book();

string strr = Myb[0];
Console.WriteLine(strr);// indexer concept //AAAA
Myb[1]=strr;
Console.WriteLine(strr);// indexer concept //AAAA


















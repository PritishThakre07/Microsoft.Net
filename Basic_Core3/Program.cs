using BankK;
using Comp;

int num = 10;
string str = "hi";

Console.WriteLine("Num "+num);
Console.WriteLine("str "+str);


var person = new { name = "person", age=10,ph="+914545"};

Console.WriteLine(person.name+" "+person.age+" "+person.ph);

Act act = new Act(5000);

Console.WriteLine("Remaining Balance "+act.withdraw(2000));

Console.WriteLine("after credited "+act.Deposite(2000));

Complex cs = new Complex();

Complex cs1 = new Complex(); 

Complex cs3 =  cs + cs1 ;
Complex cs4 =  cs - cs1 ;

Console.WriteLine("real "+cs3.real+"  imag"+cs3.imag);

Console.WriteLine("real "+cs4.real+"  imag"+cs4.imag);










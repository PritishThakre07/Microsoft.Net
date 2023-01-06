using Membership;
using HR;

Console.WriteLine("My Way");
Console.WriteLine("****************************************************");

Console.WriteLine("Enter Email");
string email = Console.ReadLine();
Console.WriteLine("Enter Password");
string password = Console.ReadLine();


if(AuthetiMember.Validate(email,password))
{
    Console.WriteLine("welcome To My Way");
    Employee emp = new SalesManager();
    Console.WriteLine(emp);



}
else{
    Console.WriteLine("Invalid Entry");
    }
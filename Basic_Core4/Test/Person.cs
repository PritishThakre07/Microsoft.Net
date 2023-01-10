namespace P;

public class Person{
    public int Id{get;set;}
    public string FirstName{get;set;}
    public string LastName{get;set;}

    public Person()
    {
        this.Id=1;
        this.FirstName="Person1";
        this.LastName="Humen";
    }

    public void Display(params string []str)
    {
        foreach(string st in str)
        {
            Console.WriteLine(st);
        }
    }

    public void Valuebyref(ref int num1,ref int num2)
    {
        int temp = num1;
         num1 = num2;
         num2 =temp;

    }

    
    public void ValuebyOut (float r ,out float area,out float circumference)
    {
        area =r*r;
        circumference = 2*r;

    }

    







}
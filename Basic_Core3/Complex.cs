namespace Comp;

public class Complex{
    public  int real;
    public  int imag;

    public Complex()
    {
        this.real = 10;
        this.imag = 10;
    }
    public Complex(int real ,int imag)
    {
        this.real = real;
        this.imag = imag;
    }

    public static Complex operator+ ( Complex c1,Complex c2)
    {
        Complex temp = new Complex();
        Console.WriteLine("In + Operator ");

        temp.real = c2.real + c1.real;
        temp.imag = c2.imag + c1.imag;

        return temp;
    }

    public  static Complex operator- ( Complex c1 , Complex c2)
    {
        Complex temp = new Complex();
        Console.WriteLine("In - Operator ");

        temp.real = c2.real - c1.real;
        temp.imag = c2.imag - c1.imag;

        return temp;
    }




}
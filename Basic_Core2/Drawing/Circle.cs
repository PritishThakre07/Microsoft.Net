namespace Drawing;

public class Circle:Shape
{
    public Point Center{get;set;}
    public int Radius{get;set;}

    public Circle()
    {
        this.Center = new Point();
        this.Radius=1;
    }

    public Circle(Point c,int r)
    {
        this.Center=c;
        this.Radius=r;
    }

    public override void Draw()
    {
        Type t = this.GetType();
        Console.WriteLine("Type ="+t.Name);
        Console.WriteLine("Center =>"+this.Center+" Rdaius="+this.Radius);
    }
    




}
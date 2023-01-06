namespace Drawing;

public class Rectangle:Shape
{
    public Point Startpt{get;set;}
    public Point Endpt{get;set;}

    public Rectangle()
    {
        this.Startpt=new Point();
        this.Endpt=new Point();
    } 
    public Rectangle(Point p1 ,Point p2)
    {
        this.Startpt=p1;
        this.Endpt=p2;
    } 

    public override void Draw()
    {
        Type t = GetType();
        Console.WriteLine(t.Name);
        Console.WriteLine("Point1=>"+ this.Startpt +"  Point2=>"+ this.Endpt +" Width="+ this.Width +" Color="+ this.Color);
    }
}
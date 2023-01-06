using Drawing;
using System.Collections.Generic;

Point pt1 = new Point(10,20);
Point pt2 = new Point(30,40);

Shape s1 = new Rectangle(pt1,pt2);

Point pt3 = new Point(50,60);

Shape s2 = new Circle(pt3,10);

List<Shape> st = new List<Shape>();

st.Add(s1);
st.Add(s2);

Console.WriteLine("Display All Shape ");

foreach (Shape s in st)
{
    s.Draw();
    
}




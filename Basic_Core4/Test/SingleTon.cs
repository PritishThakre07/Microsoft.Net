namespace Single;
public class SingleTon{
    public string FirstName{get;set;}
    public string LastName{get;set;}
    public static SingleTon _ref = null;

    SingleTon()
    {
        this.FirstName = "person";
        this.LastName = "human";

    }

    SingleTon(string str1,string str2)
    {
        this.FirstName = str1;
        this.LastName = str2;
    }


    public static SingleTon NewObject(string str1,string str2)
    {
        if(_ref == null)
        {
            _ref = new SingleTon(str1,str2);
           
             return _ref;
        }
        else
        {
            Console.WriteLine("Only One Object Is Allowe");
            return null;
        }

    }

    public static void Display(SingleTon st)
    {
        Console.WriteLine(st.FirstName+"    "+st.LastName);
    }

}
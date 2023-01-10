namespace Bk;

public class Book{
    private string [] title;

   public  Book()
    {
        title=new string[3];
        
        this.title[0] = "AAAA";
        this.title[1] = "BBBB";
        this.title[2] = "CCCC";

    }

    //this indexer syntax

    public string this[int index]
    {

        get{return title[index];}
        set {title[index] = value;}
    }
     
}
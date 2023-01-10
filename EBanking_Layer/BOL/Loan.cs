namespace BOL;
public class Loan
{
    private int id ;
    private string loanName;
    private string description;

    public Loan()
    {
    }

    public Loan(int id,string loanName,string desc)
    {
        this.id =id;
        this.loanName = loanName;
        this.description = desc;

       Console.WriteLine(" Step BOL ");


    }

    public int Id{
        get { return id;}
        set { this.id = value;}
    }


    public string LoanName{
        get {return loanName;}
        set {loanName = value;}
    }

    public string Description{

        get {return description;}

        set { description = value;}
    }




}
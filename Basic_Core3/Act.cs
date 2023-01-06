namespace BankK;

public class Act {

    private float balance;

    public Act()
    {
        this.balance=5000;

    }

    public Act(float bal)
    {
        this.balance=bal;

    }

    public float withdraw(float bal)
    {
        if( this.balance < bal)
        {
            throw new Exception("Low balance a/c");
            
        }
        this.balance=this.balance - bal;
        return this.balance;

    }
    public float Deposite(float bal)
    {
        
        this.balance=this.balance+bal;
        return this.balance;

    }

    

}
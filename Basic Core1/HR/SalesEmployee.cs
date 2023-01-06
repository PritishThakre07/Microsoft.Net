namespace HR;

public class SalesEmployee:Employee
{
    public float Target{get;set;}
    public float SalesDone{get;set;}
    public float Incentive{get;set;}

    public SalesEmployee():base()
    {
        this.Target=0;
        this.SalesDone=0;
        this.Incentive=0;
    }
    
    public SalesEmployee(int id, string firstName, string lastName, 
                    string email, string contactNumber, string location,
                    DateTime bDate, float da, float hra, float bsal,float target,float salesDone
                    ):base(id,  firstName,  lastName, 
                     email,  contactNumber,  location,
                    bDate, da, hra, bsal)
    {
        this.Target=target;
        this.Incentive=0;
        this.SalesDone=salesDone;

    }

    public override void DoWork()
    {
        if(SalesDone >= Target)
        {
            Incentive=500;
        }
        else
        {
            this.Incentive=0;
        }

    }

    public override float ComputePay()
    {
        float pay = base.ComputePay()+Incentive;
        return pay;
    }

    public override string ToString()
    {
        return base.ToString()+" Incentive = "+this.Incentive+" Target = "+this.Target;
    }

                   

}

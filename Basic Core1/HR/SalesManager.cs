namespace HR;
public class SalesManager : SalesEmployee
{
    public float Bounus{get;set;}

    public SalesManager() :base()
    {
        this.Bounus=0;
    }

    public SalesManager(int id, string firstName, string lastName, 
                    string email, string contactNumber, string location,
                    DateTime bDate, float da, float hra, float bsal,
                    float target,float salesDone,float bonus):base(id,  firstName,  lastName, 
                     email,  contactNumber,  location,
                     bDate,  da, hra, bsal,target,salesDone)
            {
                this.Bounus=bonus;
            }

    public override float ComputePay()
    {
        return base.ComputePay();

    }

    public override void DoWork()
    {
        base.DoWork();
    }

    public override string ToString()
    {
        return base.ToString()+" "+Bounus;
    }





}
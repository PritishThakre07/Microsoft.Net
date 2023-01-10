namespace BLL;
using BOL;
using DLL;


public class LoanOperational 
{
    public  List<Loan> GetAllTypeLoans()
    {
       List <Loan> alltype = new List<Loan>();

       alltype = LoanManager.GetAllTypeLoans();

       Console.WriteLine(" Step BLL ");

       return alltype;
    }

    public Loan GetLoanDetailsById( int id)
    {
        List <Loan> alltype = new List <Loan>();

        alltype = LoanManager.GetAllTypeLoans();

       Console.WriteLine("GetLoanDetailsById");


        Loan Onetype = alltype.Find((loan) => loan.Id == id );
        return Onetype;


    }

}

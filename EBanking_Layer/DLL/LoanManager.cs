namespace DLL;
using BOL;
public class LoanManager
{

    public static List<Loan> GetAllTypeLoans()
    {
        List <Loan> addtype = new List <Loan>();

        
        addtype.Add(new Loan(){Id=1 , LoanName = "Home Loan" , Description = "Home Loan At 6% "});
        addtype.Add(new Loan(){Id=2 , LoanName = "Personal Loan" , Description = "Personal Loan At 9% "});
        addtype.Add(new Loan(){Id=3 , LoanName = "Brokrage Loan" , Description = "Brokarage Loan At 5% "});
        addtype.Add(new Loan(){Id=4 , LoanName = "Industrial Loan" , Description = "Industrial Loan At 12% "});
        addtype.Add(new Loan(){Id=5 , LoanName = "FDI Loan" , Description = "FDI Loan At 25% "});
       Console.WriteLine(" Step DLL ");
       
        return addtype ;

    }
    

}

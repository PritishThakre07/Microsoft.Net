namespace Membership;
public class AuthetiMember
{
    public static bool Validate(string email,string password)
    {
        if(email == "person.com" && password == "root")
        {
            return true;
        }
        return false;
    }

    public static bool Ragister(string firstName,string lastName,string email,string location,string contactNumber)
    {
        bool status = false;
        try
        {
            User ut = new User();
            ut.FirstName=firstName;
            ut.LastName=lastName;
            ut.Email=email;
            ut.Location=location;
            ut.ContactNumber=contactNumber;
            status = true;
            
        }
        catch(Exception e){
           
        }
        finally{

        }
        return status;
    }




}

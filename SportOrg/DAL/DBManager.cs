namespace DAL;
using BOL;
using MySql.Data.MySqlClient;


public class DBManager
{
    public static string constring = @"server=127.0.0.1;port=3306;user=root;password=root123;
    database=sportsystem";
     
    public static List<Player> GetAll(){

        MySqlConnection con = new MySqlConnection();

        con.ConnectionString=constring;

        List<Player> allply =new List<Player>();

        try{

            con.Open();
            string query = "SELECT * FROM players";
            
            MySqlCommand cmd = new MySqlCommand(query,con);
            
            MySqlDataReader reader = cmd.ExecuteReader();

            while(reader.Read())
            {
                int id = int.Parse(reader["id"].ToString());
                string name = reader["name"].ToString();
                string game = reader["game"].ToString();

                Player ply = new Player(id,name,game);
                

                allply.Add(ply);
            }


        }
        catch(Exception e){
            Console.WriteLine(e.Message);

        }finally{
            con.Close();
        } 
        return allply;

    }

    public static List<Player> DetailsAll()
    {
        List<Player> allply =new List<Player>();
        
        MySqlConnection con = new MySqlConnection();
        con.ConnectionString=constring;
        try{
            con.Open();
            string query = "SELECT * FROM players";
            MySqlCommand cmd = new MySqlCommand(query,con);

            MySqlDataReader reader = cmd.ExecuteReader();

            while(reader.Read())
            {
                int id = int.Parse(reader["id"].ToString());
                string name = reader["name"].ToString();
                string game = reader["game"].ToString();

                Player ply = new Player(id,name,game);
                 allply.Add(ply);
            }


        }catch(Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally{
            con.Close();
        }
        return allply;
    }

    public static bool Insert(Player ply)
    {
        bool status = false;
        string constring =@"server=localhost;port=3306;user=root;password=root123;database=sportsystem";
        MySqlConnection con = new MySqlConnection();
        con.ConnectionString= constring;

        try{
            con.Open();
            string query ="INSERT INTO players(id,name,game)"+ " VALUES('"+ply.Id+"','"+ply.Name+"','"+ply.Game+"')";
            MySqlCommand cmd = new MySqlCommand(query,con);

            cmd.ExecuteNonQuery();
            status=true;
        }
        catch(Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally{
            con.Close();
        }
        return status;
    }


    public static Player GetOne(int id)
    {
        string constring =@"server=localhost;port=3306;user=root;password=root123;database=sportsystem";
        MySqlConnection con = new MySqlConnection();
        con.ConnectionString=constring;
        Player ply = null;
        try{
            con.Open();
            string query="SELECT * FROM players WHERE id="+id;
            MySqlCommand cmd = new MySqlCommand(query,con);
            MySqlDataReader reader = cmd.ExecuteReader();

            if(reader.Read())
            {
                int Id = int.Parse(reader["id"].ToString());
                string name = reader["name"].ToString();
                string game = reader["game"].ToString();

                 ply = new Player(Id,name,game);
                 
            }
            reader.Close();

        }catch(Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally{
            con.Close();
        }
        return ply;
       

    }
    public static bool Update(Player ply)
    {
        string constring = @"server=localhost;port=3306;user=root;password=root123;database=sportsystem";
        bool status = false;





        MySqlConnection con = new MySqlConnection();
        con.ConnectionString = constring;
        try{
            con.Open();
            string query = "UPDATE players SET id='" + ply.Id + "', name='" + ply.Name + "' WHERE id=" + ply.Id;
             
             MySqlCommand cmd = new MySqlCommand(query,con);

             cmd.ExecuteNonQuery();

              status=true;


        }catch(Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally{
            con.Close();

        }
        return status;

    } 




    

    


}

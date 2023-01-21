namespace BOL;
public class Player
{
    public int Id{get;set;}
    public string Name{get;set;}
    public string Game{get;set;}

    

    public Player()
    {
    
    }

    public Player(int id,string name,string game)
    {
        this.Id=id;
        this.Name=name;
        this.Game=game;

    }


    public override string ToString()
    {
        return "Id : "+Id+" Name: "+Name+" Game: "+Game;
    }

    


}

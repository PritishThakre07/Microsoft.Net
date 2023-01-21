namespace BLL;
using BOL;
using DAL;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;
using System.Collections.Generic;


public class Middleware
{
    public List<Player> GetAllPlayer()
    {

        List<Player> allply = new List<Player>();

        allply = DBManager.GetAll();


        return allply;

    }

    public List<Player> DetailsAll()
    {
        List<Player> allply = new List<Player>();

        allply = DBManager.DetailsAll();

        string filename = @"D:\Microsoft.NET\dotnet\Day12\SportOrg\player.Json";
        try{

                var ser = new JsonSerializerOptions {IncludeFields=true};


            var ply = JsonSerializer.Serialize<List<Player>>(allply,ser);

            File.WriteAllText(filename,ply);


        }catch(Exception e){ }finally{ }

        return allply;
    }

    public List<Player> Details()
    {
        string fileName = @"D:\Microsoft.NET\dotnet\Day12\SportOrg\player.Json";
        string jsonString = File.ReadAllText(fileName);
        List<Player> all = JsonSerializer.Deserialize<List<Player>>(jsonString);
        return all;
    } 


    

 

    public bool Insert(Player ply)
    {
        bool status = DBManager.Insert(ply);
        return status;
    }

    public Player GetOne(int id)
    {
        Player ply = DBManager.GetOne(id);
        return ply;
    }

    public bool Upadte(Player ply)
    {

        bool status = DBManager.Update(ply);
        return status;
    }







}

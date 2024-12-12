using _2._2_dars.Modeles;
using _2._2dars.Api.Models;
using System.Text.Json;
namespace _2._2_dars.Services;

public class Suxrob
{
    private string suxrobFilePath;
    private Guid Id;

    public Suxrob()
    {
        suxrobFilePath="../../Data/Suxrob.Json";
        if(File.Exists(suxrobFilePath)is false)
        {
            File.WriteAllText(suxrobFilePath,"[]");
        }
    }

    public Suxrob AddSuxrob(Suxrob suxrob)
    {
        var suxrobId=Guid.NewGuid();
        var suxrobs = GetSuxrob();
        suxrobs.Add(suxrob);
        SaveData(suxrobs);
        return suxrob;
    }

    public Suxrob GetById(Guid suxrobId)
    {
        var suxrobs=GetSuxrob();
        foreach(var suxrob in suxrobs)
        {
            if (suxrob.Id==suxrobId)
            {
                return suxrob;
            }
        }
        return null;
    }
    public bool DeleteSuxrob(Guid suxrobId)
    {
        var suxrobs= GetSuxrob();
        var suxrobFromDb=GetById(suxrobId);
        if(suxrobFromDb is null)
        {
            return false;
        }
        suxrobs.Remove(suxrobFromDb);
        SaveData(suxrobs);
        return true;
    }
    public bool UpdeteSuxrob(Suxrob suxrob)
    {
        var suxrobs = GetSuxrob();
        var suxrobFromDb = GetById(suxrob.Id);
        if (suxrobFromDb is null)
        {
            return false;
        }
        var index=suxrobs.IndexOf(suxrob);
        suxrobs[index] = suxrob;
        SaveData(suxrobs);
        return true;
    }

    public List<Suxrob> GetAllSuxrob()
    {
        return GetSuxrob();
    }


    private void SaveData(List<Suxrob> suxrob)
    {
        var suxrobJson = JsonSerializer.Serialize(suxrob);
        File.WriteAllText(suxrobJson, suxrobFilePath);
    }

    private List<Suxrob> GetSuxrob()
    {
        var suxrobJson=File.ReadAllText(suxrobFilePath);
        var suxrobs=JsonSerializer.Deserialize<List<Suxrob>>(suxrobJson);
        return suxrobs;
    }
}

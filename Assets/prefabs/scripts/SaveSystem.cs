using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveSystem
{
    public static void SavePlayer (Player player)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/player.fun";
        FileStream stream = new FileStream(path, FileMode.Create);

        PlayerData data = new PlayerData(player);

        formatter.Serialize(stream, data);
       
        stream.Close();
    }

    public static PlayerData LoadPlayer()
    {
        string path = Application.persistentDataPath + "/player.fun";
        FileStream stream = new FileStream(path, FileMode.Open);
        if (File.Exists(path) && stream.Length > 0)
        {
            BinaryFormatter formatter = new BinaryFormatter();


            Debug.Log("OLD");
            PlayerData data = formatter.Deserialize(stream) as PlayerData;
          
            stream.Close();
            
            return data;
        }
        else
        {
            Debug.Log("NEW");
            PlayerData data = new PlayerData();
            return data;
        }
    }

    public static void DeletePlayerData()
    {
        string path = Application.persistentDataPath + "/player.fun";
        if (File.Exists(path))
        {
            File.Delete(path);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System.IO;
//%userprofile%\AppData\LocalLow
public static class SaveSystem
{
    public static string _fullPath;
    public static string directory = "/SaveData/", filename = "myData.txt";
    public static void SaveData(Save data)
    {
        PlayerPrefs.SetInt("firstTimePlaying", 1); // 0 para primera vez, 1 para ya ah jugado y guardado
        Debug.Log("sAVING");
        string dir = Application.persistentDataPath + directory;
        if (!Directory.Exists(dir))
        {
            Directory.CreateDirectory(dir);
        }
        string json = JsonUtility.ToJson(data);
        File.WriteAllText(dir + filename, json);
    }
    public static bool ifIsFirstPlay() => File.Exists(_fullPath);
    public static Save Load()
    {
        Debug.Log("LOADING");
        string fullPath = Application.persistentDataPath + directory + filename; 
        _fullPath = fullPath;
        Save data = new Save();
        if (File.Exists(fullPath))
        {

            string json = File.ReadAllText(fullPath);
            data = JsonUtility.FromJson<Save>(json);
        }
        else
        {
            Debug.Log("file dosent exist");
        }
        return data;
    }
    
}

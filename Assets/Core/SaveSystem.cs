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
        Debug.Log("sAVING");
        string dir = Application.persistentDataPath + directory;
        if (!Directory.Exists(dir))
        {
            Directory.CreateDirectory(dir);
        }
        string json = JsonUtility.ToJson(data);
        File.WriteAllText(dir + filename, json);
    }
    public static bool ifIsFirstPlay() => File.Exists(Application.persistentDataPath+directory+filename);
    public static Save Load()
    {
        Debug.Log("LOADING");
        string fullPath = Application.persistentDataPath + directory + filename; 
        Debug.Log($"{fullPath}");
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

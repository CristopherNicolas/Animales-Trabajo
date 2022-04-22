using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public float dinero;
    public static GameManager instance;
    public Save partidaGuardada;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
             DontDestroyOnLoad(gameObject);
            SaveGame();
        }
    }
    public void LoadGame()
    {
       partidaGuardada = SaveSystem.Load();
    }
    public void SaveGame()
    {
        SaveSystem.SaveData(partidaGuardada);
    }
}
public enum GRUPOANIMAL
{
   Canino, Felino,Ave
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// contiene la partida guardada,
/// </summary>
public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public Save partidaGuardada;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            //comprueba si es la primera vez jugando:
             if(SaveSystem.ifIsFirstPlay())

             DontDestroyOnLoad(gameObject);
             SaveGame();
          //  LoadGame();
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
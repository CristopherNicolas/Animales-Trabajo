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
    public Animal cat;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
             DontDestroyOnLoad(gameObject);
            //comprueba si es la primera vez jugando:
             if(SaveSystem.ifIsFirstPlay())
            {
                NewGame();
            }
          else
           LoadGame();
        }
        Debug.Log(GameManager.instance.partidaGuardada);
    }
    public void LoadGame()
    {
       partidaGuardada = SaveSystem.Load();
    }
    public void SaveGame()
    {
        SaveSystem.SaveData(partidaGuardada);
    }
    public void NewGame()
    {
          SaveSystem.SaveData(partidaGuardada);
    }
}
public enum GRUPOANIMAL
{
   Canino, Felino,Ave
}
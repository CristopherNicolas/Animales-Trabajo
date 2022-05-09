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
    public Animal defaulAnimal;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
             DontDestroyOnLoad(gameObject);
            //comprueba si es la primera vez jugando:
             if(SaveSystem.ifIsFirstPlay())
            {

            }

          //   SaveGame();
           LoadGame();
        }
    }
    public void LoadGame()
    {
       partidaGuardada = SaveSystem.Load();
        if (partidaGuardada.animalesEnTerrenos.Count == 0)
        {
            partidaGuardada.animalesEnTerrenos.Add(defaulAnimal);
        }
    }
    public void SaveGame()
    {
        SaveSystem.SaveData(partidaGuardada);
        
    }
    public void NewGame()
    {
        LoadGame();

    }
}




public enum GRUPOANIMAL
{
   Canino, Felino,Ave
}
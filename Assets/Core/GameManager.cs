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
            if (SaveSystem.ifIsFirstPlay())
            {
                NewGame();
            }
            else

                LoadGame();
                if(partidaGuardada.animalEnTerreno==null)
                {
                    partidaGuardada.animalEnTerreno = new List<string>();
                    Debug.Log("flag 1");
                if(partidaGuardada.animalEnTerreno.Count==0)
                {
                    partidaGuardada.animalEnTerreno.Add("Gato");
                }
                }
        }
        else Destroy(gameObject);
        Debug.Log(GameManager.instance.partidaGuardada);
    }
    public void LoadGame()=> partidaGuardada = SaveSystem.Load();
    public void SaveGame()=> SaveSystem.SaveData(partidaGuardada);
    public void NewGame()=> SaveSystem.SaveData(partidaGuardada);    
}
public enum GRUPOANIMAL
{
   Canino, Felino,Ave
}
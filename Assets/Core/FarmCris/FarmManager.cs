using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class FarmManager : MonoBehaviour
{
    public List<Animal> animalesEnTerrenos;
    private void Awake()
    {
      CargarTerrenos();        
    }
    private void CargarTerrenos()
    {
      animalesEnTerrenos =  GameManager.instance.partidaGuardada.animalesEnTerrenoCris;
    }
    public void GuardarDatosDeTerreno()
    {
      GameManager.instance.partidaGuardada.animalesEnTerrenoCris = animalesEnTerrenos;
      GameManager.instance.SaveGame();
    }
     
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoSave : MonoBehaviour
{
    public List<Animal> animales;
    public bool canAuto=true;
    
    void Start()
    {
       if(canAuto)
      StartCoroutine(SaveAnimals());
    }
    public void StartSave()=>StartCoroutine(SaveAnimals());
    public IEnumerator SaveAnimals()
    {
        GameManager.instance.partidaGuardada.animalesEnTerrenos = new List<Animal>();
       while(true)      
        {
            //convert form string to animal
            if(TerrenoManager.instance.AnimalTerreno1!="")
            {
               GameManager.instance.partidaGuardada.animalEnTerreno.Add(TerrenoManager.instance.AnimalTerreno1); 
            }
            if(TerrenoManager.instance.AnimalTerreno2!="")
            {
               GameManager.instance.partidaGuardada.animalEnTerreno.Add(TerrenoManager.instance.AnimalTerreno2); 
            }
            if(TerrenoManager.instance.AnimalTerreno3!="")
            {
               GameManager.instance.partidaGuardada.animalEnTerreno.Add(TerrenoManager.instance.AnimalTerreno3); 
            }
            if(TerrenoManager.instance.AnimalTerreno4!="")
            {
               GameManager.instance.partidaGuardada.animalEnTerreno.Add(TerrenoManager.instance.AnimalTerreno4); 
            }
            if(TerrenoManager.instance.AnimalTerreno5!="")
            {
               GameManager.instance.partidaGuardada.animalEnTerreno.Add(TerrenoManager.instance.AnimalTerreno5); 
            }
            if(TerrenoManager.instance.AnimalTerreno6!="")
            {
               GameManager.instance.partidaGuardada.animalEnTerreno.Add(TerrenoManager.instance.AnimalTerreno6); 
            }
             GameManager.instance.SaveGame();
            yield return new  WaitForSeconds(5);
        }
    }
    public void SaveAnimals(bool t)
    {
        GameManager.instance.partidaGuardada.animalesEnTerrenos = new List<Animal>();
       
            //convert form string to animal
            if(TerrenoManager.instance.AnimalTerreno1!="")
            {
               GameManager.instance.partidaGuardada.animalEnTerreno.Add(TerrenoManager.instance.AnimalTerreno1); 
            }
            if(TerrenoManager.instance.AnimalTerreno2!="")
            {
               GameManager.instance.partidaGuardada.animalEnTerreno.Add(TerrenoManager.instance.AnimalTerreno2); 
            }
            if(TerrenoManager.instance.AnimalTerreno3!="")
            {
               GameManager.instance.partidaGuardada.animalEnTerreno.Add(TerrenoManager.instance.AnimalTerreno3); 
            }
            if(TerrenoManager.instance.AnimalTerreno4!="")
            {
               GameManager.instance.partidaGuardada.animalEnTerreno.Add(TerrenoManager.instance.AnimalTerreno4); 
            }
            if(TerrenoManager.instance.AnimalTerreno5!="")
            {
               GameManager.instance.partidaGuardada.animalEnTerreno.Add(TerrenoManager.instance.AnimalTerreno5); 
            }
            if(TerrenoManager.instance.AnimalTerreno6!="")
            {
               GameManager.instance.partidaGuardada.animalEnTerreno.Add(TerrenoManager.instance.AnimalTerreno6); 
            }
        GameManager.instance.SaveGame();
    }
}

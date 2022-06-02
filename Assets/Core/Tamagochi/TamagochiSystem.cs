using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using System.Linq;
public class TamagochiSystem : MonoBehaviour
{
    public CambiarTamagochi cambiarTamagochi;
    public Personaje personaje;
    public BgController bgController;
    public List<Animal> animales;
    private void Awake()
    {
        bgController = GameObject.Find("Canvas").GetComponent<BgController>();
        cambiarTamagochi = GetComponent<CambiarTamagochi>(); 
    }
    private  void Start()
    {
        try
        {
        AsignarAnimal(cambiarTamagochi.animales[cambiarTamagochi.i]);                    

        }   
        catch(Exception e)
        {
         GameManager.instance.partidaGuardada.animalesEnTerrenos = new List<Animal>();
              GameManager.instance.partidaGuardada.animalesEnTerrenos.Add(GameManager.instance.cat);
        } 
        if(GameManager.instance.partidaGuardada.animalesEnTerrenos==null)
        {
            GameManager.instance.partidaGuardada.animalesEnTerrenos = new List<Animal>();
              GameManager.instance.partidaGuardada.animalesEnTerrenos.Add(GameManager.instance.cat);
        }
         bgController.AnimarColorBg();
    }
    public void AsignarAnimal(Animal a)
    {
        TransformarAnimales();    
           bgController.CambiarBG(a);
        //cambiar stats
        UiSystem.instance.UpdateUI();
    }

    public void TransformarAnimales()
    {
        foreach(var animal in GameManager.instance.partidaGuardada.animalEnTerreno)
        {
            //"Gato" "Perro" "Pato" "Tigre" "Zorro" "Pollo"
            if(animal=="Gato")
                GameManager.instance.partidaGuardada.animalesEnTerrenos.Add(animales[0]);
            else if(animal=="Perro") GameManager.instance.partidaGuardada.animalesEnTerrenos.Add(animales[1]);
            else if(animal=="Pato") GameManager.instance.partidaGuardada.animalesEnTerrenos.Add(animales[2]);
            else if(animal=="Tigre") GameManager.instance.partidaGuardada.animalesEnTerrenos.Add(animales[3]);
            else if(animal=="Zorro") GameManager.instance.partidaGuardada.animalesEnTerrenos.Add(animales[4]);
            else if(animal=="Pollo") GameManager.instance.partidaGuardada.animalesEnTerrenos.Add(animales[5]);
        }
    }    
    
    
}

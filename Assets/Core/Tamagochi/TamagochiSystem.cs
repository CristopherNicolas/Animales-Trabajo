using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using System.Linq;
public class TamagochiSystem : MonoBehaviour
{
    public Personaje personaje;
    public BgController bgController;
    public List<Animal> animales;
    private void Awake()
    {
        bgController = GameObject.Find("Canvas").GetComponent<BgController>();
    }
    private async void Start()
    {
        AsignarAnimal();                    
        await bgController.AnimarColorBg();
    }
    public void AsignarAnimal()
    {
      //  GameManager.instance.partidaGuardada.animalesEnTerrenos = new List<Animal>();
         GameManager.instance.partidaGuardada.animalesEnTerrenos.Add(GameManager.instance.cat);
           bgController.CambiarBG(GameManager.instance.partidaGuardada.animalesEnTerrenos.First());
        personaje.image.sprite = GameManager.instance.partidaGuardada.animalesEnTerrenos.First().imagenAnimal;
        AudioManager.instance.PonerCancionAnimal(GameManager.instance.partidaGuardada.animalesEnTerrenos.First());
        //cambiar stats
        UiSystem.instance.UpdateUI();
    }
    
    
}

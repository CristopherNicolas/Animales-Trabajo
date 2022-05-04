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
        //GameManager.instance.partidaGuardada.animalParaTamagochi = 
        bgController = GameObject.Find("Canvas").GetComponent<BgController>();
    }
    private void Start()
    {
        AsignarAnimal();
        
    }

    public void AsignarAnimal()
    {
        bgController.CambiarBG(GameManager.instance.partidaGuardada.animalesEnTerrenos.First());
        personaje.image.sprite = GameManager.instance.partidaGuardada.animalesEnTerrenos.First().imagenAnimal;
        //cambiar stats
    }
    
    //interaccion con el jugador
}

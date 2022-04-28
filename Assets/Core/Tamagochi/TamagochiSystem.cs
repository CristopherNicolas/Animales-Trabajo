using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
public class TamagochiSystem : MonoBehaviour
{
    public Personaje personaje;
  
    BgController bgController;
    public List<Animal> animales; 
    private void Awake()
    {
        //GameManager.instance.partidaGuardada.animalParaTamagochi = 
        bgController = GameObject.Find("Canvas").GetComponent<BgController>();
        AsignarAnimal();
    }
    public void AsignarAnimal()
    {
        Debug.Log(GameManager.instance.partidaGuardada.animalParaTamagochi.name);

        var q = from Animal a in animales
                where a.name == GameManager.instance.partidaGuardada.animalParaTamagochi.name
                select a;
        Debug.Log($"se ha cargado el animal : {q.First()} desde la partida guardada");
        bgController.CambiarBG(q.First());
        personaje.image.sprite = q.First().imagenAnimal;
        //cambiar stats
    }
    

}

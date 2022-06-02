using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class CambiarTamagochi : MonoBehaviour
{
  public List<Animal> animales;
    public int terrenoActual = 0;
    public TamagochiSystem tamagochiSystem;
   public  AutoSave autoSave;
    // cambiar tamagochi al presionar los botones
  public int i=0;
    public void CambiarAnimal()
    {
        i+=1;
        if(i>=animales.Count)
        {
            i=0;
        }
        if(i!=0)
        {
         tamagochiSystem.personaje.image.transform.localScale = new Vector3(0.34f,0.42f,0.42f);
        } 
        else  tamagochiSystem.personaje.image.transform.localScale = Vector3.one;
        tamagochiSystem.personaje.image.sprite = animales[i].imagenAnimal;
        tamagochiSystem.personaje.tipoDeAnimal = animales[i];
        tamagochiSystem.AsignarAnimal(animales[i]);
    }
}

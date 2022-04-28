using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
/// <summary>
/// el personaje contiene todos los comportameintos del animal
/// </summary>
public class Personaje : MonoBehaviour
{
    public Image image;
    public Animal tipoDeAnimal;
    public  float Diversion { get; set; }
      public void ShowMessaje()
    {
        UiSystem.instance.EnviarMensaje("Hola");
    }
}

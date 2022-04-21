using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
public class BgController : MonoBehaviour
{
   [SerializeField]Image bg;
    public Animal animalSeleccionado;     
    public void CambiarBG(Animal animalActual)
    {
        bg.color = animalActual.colorParaBgSystem;
    }
}

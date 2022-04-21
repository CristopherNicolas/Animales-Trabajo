using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[System.Serializable]
public abstract class Animal: MonoBehaviour
{
    public Sprite imagenAnimal;
    public Color colorParaBgSystem;
    public GRUPOANIMAL grupo;
    public virtual float ObtenerOro() => 1;

}

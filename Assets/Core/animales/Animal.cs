using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[System.Serializable]
public abstract class Animal: MonoBehaviour
{
    public Sprite imagenAnimal;
    public AudioClip cancionAnimal;
    public Color colorParaBgSystem,colorPlataforma;
    public GRUPOANIMAL grupo;
    public virtual float ObtenerOro() => 1;
    public virtual float ObtenerAlimento()=>1;
}

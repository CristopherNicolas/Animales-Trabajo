using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI ;

public class Alimento : MonoBehaviour,IComprable
{
    public float GetPrecio() => 10;
    public Sprite GetSprite() => gameObject.GetComponent<Image>().sprite;
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TerrenoManager : MonoBehaviour
{
    public List<GameObject> Terrenos;
    public bool used1, used2, used3, used4, used5, used6;
    public bool TerrenoDisponible;
    public Text ContadorT1, ContadorT2, ContadorT3, ContadorT4, ContadorT5, ContadorT6;
    public GameObject AnimalSprite1, AnimalSprite2, AnimalSprite3, AnimalSprite4, AnimalSprite5, AnimalSprite6;
    public string AnimalTerreno1, AnimalTerreno2, AnimalTerreno3, AnimalTerreno4, AnimalTerreno5, AnimalTerreno6;
    public static TerrenoManager instance;
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    private void FixedUpdate()
    {
        terrenoDisponible();
        ContadorT1.text = "" + Tienda.instance.AnimalesEnT1;
        ContadorT2.text = "" + Tienda.instance.AnimalesEnT2;
        ContadorT3.text = "" + Tienda.instance.AnimalesEnT3;
        ContadorT4.text = "" + Tienda.instance.AnimalesEnT4;
        ContadorT5.text = "" + Tienda.instance.AnimalesEnT5;
        ContadorT6.text = "" + Tienda.instance.AnimalesEnT6;
    }
    private void terrenoDisponible()
    {
        if(used1 && used2 && used3 && used4 && used5 && used6)
        {
            TerrenoDisponible = false;
        }
        else
        {
            TerrenoDisponible = true;
        }
    }

    public void SinAnimales()
    {
        
    }
}

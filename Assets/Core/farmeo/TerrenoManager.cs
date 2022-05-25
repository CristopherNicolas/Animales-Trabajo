using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrenoManager : MonoBehaviour
{
    public List<GameObject> Terrenos;
    public bool used1, used2, used3, used4, used5, used6;
    public bool TerrenoDisponible;
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
}

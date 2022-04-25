using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Terreno : MonoBehaviour
{
    // Start is called before the first frame update
    public List<Animal> terrenos;
    public bool Used;
    void Start()
    {
        terrenos.Add(new Cat());
        terrenos.Add(new Dog());
        terrenos[0].ObtenerOro();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TerrenoNotUsed()
    {
        if (Used == false)
        {
            Tienda.instance.AbrirTienda();
        }
    }
}

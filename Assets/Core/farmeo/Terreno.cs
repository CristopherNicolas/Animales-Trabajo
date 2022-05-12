    using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Terreno : MonoBehaviour
{
    // Start is called before the first frame update
    public int maxAnimals = 10;
    public List<Animal> animals;
    public List<GameObject> Sprites;
    public bool Used;
    public void ClickearTerreno()
    {
        if (Used == false)
        {
            Tienda.instance.AbrirTienda();
        }
        else
        {
            // aqui añadir oro
        }
    }
}

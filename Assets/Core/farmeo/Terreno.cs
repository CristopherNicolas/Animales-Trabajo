    using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Terreno : MonoBehaviour
{
    // Start is called before the first frame update
    public List<Animal> terrenos;
    public bool Used;

    // Update is called once per frame
    public void VaciarSprite() => GetComponent<Image>().sprite = Tienda.instance.tiendaEmptySlot;
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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class Tienda : MonoBehaviour
{
    bool IsOpen;
    public Terreno terrain;
    public List<GameObject> Terrenos;
    public static Tienda instance;
    public List<GameObject> animales;
    public void Awake()
    {
        if  (instance == null)
        {
            instance = this;
            GetComponent<RectTransform>().DOScale(0, 0);
            terrain = GetComponent<Terreno>();
        }
    }
    public void AbrirTienda()
    {
        if (IsOpen)
        {
            CerrarTienda();
            return;
        }
        GetComponent<RectTransform>().DOScale(1, 0.5f);
        IsOpen = true;
    }

    public void CerrarTienda()
    {
        GetComponent<RectTransform>().DOScale(0, 0.5f);
        IsOpen = false;
    }


    public void Comprar(float precio)
    {
        if (GameManager.instance.partidaGuardada.dinero >= precio)
        {
            if (Terrenos[0] = terrain.Used)
            {

            }
        }
        else
        {
            //no se puede comprar
        }
    }

}

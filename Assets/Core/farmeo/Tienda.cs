using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class Tienda : MonoBehaviour
{
    bool IsOpen;
    public static Tienda instance;
    public List<GameObject> terrenos;
    public List<GameObject> animales;
    public Sprite tiendaEmptySlot;
    public void Awake()
    {
        if  (instance == null)
        {
            instance = this;
            GetComponent<RectTransform>().DOScale(0, 0);
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


    public void Comprar(float precio,IComprable comprable)
    {
        // 6 espacios posibles
        // el primero siempre esta usado
        //como saber si estan en uso
        if (GameManager.instance.partidaGuardada.dinero>=precio)
        {
            //asignar sprite
         
            
            // descontar dinero
            GameManager.instance.partidaGuardada.dinero -=
                comprable.GetPrecio();
            for (int i = 0; i < terrenos.Count; i++)
            {
                if (terrenos[i].GetComponent<Image>().sprite.name == "UISprite")
                {
                    //entonces puede crear en el terreno
                    terrenos[i].GetComponent<Image>().sprite = comprable.GetSprite(); break;
                }
            }
        }
        else
        {
            //no se puede copmprar
        }
    }

}

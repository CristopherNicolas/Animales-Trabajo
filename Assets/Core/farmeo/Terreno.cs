    using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Terreno : MonoBehaviour
{
    public float GananciasT1,GananciasT2,GananciasT3,GananciasT4, GananciasT5, GananciasT6;
    public static Terreno instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }

    }
    private void Start()
    {
        StartCoroutine(GanarDineroT1());
        StartCoroutine(GanarDineroT2());
        StartCoroutine(GanarDineroT3());
        StartCoroutine(GanarDineroT4());
        StartCoroutine(GanarDineroT5());
        StartCoroutine(GanarDineroT6());
    }
    private void Update()
    {

    }

    public void ClickearTerreno1()
    {
        if (TerrenoManager.instance.used1 == false)
        {
            Tienda.instance.AbrirTienda();
        }
        else
        {
            GameManager.instance.partidaGuardada.dinero += GananciasT1;
            GananciasT1 = 0f;
            
        }
    }
    public void ClickearTerreno2()
    {
        if (TerrenoManager.instance.used2 == false)
        {
            Tienda.instance.AbrirTienda();
        }
        else
        {
            GameManager.instance.partidaGuardada.dinero += GananciasT2;
            GananciasT2 = 0f;
        }
    }
    public void ClickearTerreno3()
    {
        if (TerrenoManager.instance.used3 == false)
        {
            Tienda.instance.AbrirTienda();
        }
        else
        {
            GameManager.instance.partidaGuardada.dinero += GananciasT3;
            GananciasT3 = 0f;
        }
    }
    public void ClickearTerreno4()
    {
        if (TerrenoManager.instance.used4 == false)
        {
            Tienda.instance.AbrirTienda();
        }
        else
        {
            GameManager.instance.partidaGuardada.dinero += GananciasT4;
            GananciasT4 = 0f;
        }
    }
    public void ClickearTerreno5()
    {
        if (TerrenoManager.instance.used5 == false)
        {
            Tienda.instance.AbrirTienda();
        }
        else
        {
            GameManager.instance.partidaGuardada.dinero += GananciasT5;
            GananciasT5 = 0f;
        }
    }
    public void ClickearTerreno6()
    {
        if (TerrenoManager.instance.used6 == false)
        {
            Tienda.instance.AbrirTienda();
        }
        else
        {
            GameManager.instance.partidaGuardada.dinero += GananciasT6;
            GananciasT6 = 0f;
        }
    }

    IEnumerator GanarDineroT1()
    {
        yield return new WaitForSeconds(2f);
        switch (TerrenoManager.instance.AnimalTerreno1)
        {
            case "Gato":
                GananciasT1 += (Tienda.instance.precioGato / 4f) * Tienda.instance.AnimalesEnT1;
                break;
            case "Perro":
                GananciasT1 += (Tienda.instance.precioPerro / 4f) * Tienda.instance.AnimalesEnT1;
                break;
            case "Pato":
                GananciasT1 += (Tienda.instance.precioPato / 4f) * Tienda.instance.AnimalesEnT1;
                break;
            case "Tigre":
                GananciasT1 += (Tienda.instance.precioTigre / 4f) * Tienda.instance.AnimalesEnT1;
                break;
            case "Zorro":
                GananciasT1 += (Tienda.instance.precioZorro / 4f) * Tienda.instance.AnimalesEnT1;
                break;
            case "Pollo":
                GananciasT1 += (Tienda.instance.precioPollo / 4f) * Tienda.instance.AnimalesEnT1;
                break;
            default:
                break;
        }
        StartCoroutine(GanarDineroT1());
    }
    IEnumerator GanarDineroT2()
    {
        yield return new WaitForSeconds(2f);
        switch (TerrenoManager.instance.AnimalTerreno2)
        {
            case "Gato":
                GananciasT2 += (Tienda.instance.precioGato / 4f) * Tienda.instance.AnimalesEnT2;
                break;
            case "Perro":
                GananciasT2 += (Tienda.instance.precioPerro / 4f) * Tienda.instance.AnimalesEnT2;
                break;
            case "Pato":
                GananciasT2 += (Tienda.instance.precioPato / 4f) * Tienda.instance.AnimalesEnT2;
                break;
            case "Tigre":
                GananciasT2 += (Tienda.instance.precioTigre / 4f) * Tienda.instance.AnimalesEnT2;
                break;
            case "Zorro":
                GananciasT2 += (Tienda.instance.precioZorro / 4f) * Tienda.instance.AnimalesEnT2;
                break;
            case "Pollo":
                GananciasT2 += (Tienda.instance.precioPollo / 4f) * Tienda.instance.AnimalesEnT2;
                break;
            default:
                break;
        }
        StartCoroutine(GanarDineroT2());
    }
    IEnumerator GanarDineroT3()
    {
        yield return new WaitForSeconds(2f);
        switch (TerrenoManager.instance.AnimalTerreno3)
        {
            case "Gato":
                GananciasT3 += (Tienda.instance.precioGato / 4f) * Tienda.instance.AnimalesEnT3;
                break;
            case "Perro":
                GananciasT3 += (Tienda.instance.precioPerro / 4f) * Tienda.instance.AnimalesEnT3;
                break;
            case "Pato":
                GananciasT3 += (Tienda.instance.precioPato / 4f) * Tienda.instance.AnimalesEnT3;
                break;
            case "Tigre":
                GananciasT3 += (Tienda.instance.precioTigre / 4f) * Tienda.instance.AnimalesEnT3;
                break;
            case "Zorro":
                GananciasT3 += (Tienda.instance.precioZorro / 4f) * Tienda.instance.AnimalesEnT3;
                break;
            case "Pollo":
                GananciasT3 += (Tienda.instance.precioPollo / 4f) * Tienda.instance.AnimalesEnT3;
                break;
            default:
                break;
        }
        StartCoroutine(GanarDineroT3());
    }
    IEnumerator GanarDineroT4() 
    {
        yield return new WaitForSeconds(2f);
        switch (TerrenoManager.instance.AnimalTerreno4)
        {
            case "Gato":
                GananciasT4 += (Tienda.instance.precioGato / 4f) * Tienda.instance.AnimalesEnT4;
                break;
            case "Perro":
                GananciasT4 += (Tienda.instance.precioPerro / 4f) * Tienda.instance.AnimalesEnT4;
                break;
            case "Pato":
                GananciasT4 += (Tienda.instance.precioPato / 4f) * Tienda.instance.AnimalesEnT4;
                break;
            case "Tigre":
                GananciasT4 += (Tienda.instance.precioTigre / 4f) * Tienda.instance.AnimalesEnT4;
                break;
            case "Zorro":
                GananciasT4 += (Tienda.instance.precioZorro / 4f) * Tienda.instance.AnimalesEnT4;
                break;
            case "Pollo":
                GananciasT4 += (Tienda.instance.precioPollo / 4f) * Tienda.instance.AnimalesEnT4;
                break;
            default:
                break;
        }
        StartCoroutine(GanarDineroT4());
    }
    IEnumerator GanarDineroT5()
    {
        yield return new WaitForSeconds(2f);
        switch (TerrenoManager.instance.AnimalTerreno5)
        {
            case "Gato":
                GananciasT5 += (Tienda.instance.precioGato / 4f) * Tienda.instance.AnimalesEnT5;
                break;
            case "Perro":
                GananciasT5 += (Tienda.instance.precioPerro / 4f) * Tienda.instance.AnimalesEnT5;
                break;
            case "Pato":
                GananciasT5 += (Tienda.instance.precioPato / 4f) * Tienda.instance.AnimalesEnT5;
                break;
            case "Tigre":
                GananciasT5 += (Tienda.instance.precioTigre / 4f) * Tienda.instance.AnimalesEnT5;
                break;
            case "Zorro":
                GananciasT5 += (Tienda.instance.precioZorro / 4f) * Tienda.instance.AnimalesEnT5;
                break;
            case "Pollo":
                GananciasT5 += (Tienda.instance.precioPollo / 4f) * Tienda.instance.AnimalesEnT5;
                break;
            default:
                break;
        }
        StartCoroutine(GanarDineroT5());
    }
    IEnumerator GanarDineroT6()
    {
        yield return new WaitForSeconds(2f);
        switch (TerrenoManager.instance.AnimalTerreno6)
        {
            case "Gato":
                GananciasT6 += (Tienda.instance.precioGato / 4f) * Tienda.instance.AnimalesEnT6;
                break;
            case "Perro":
                GananciasT6 += (Tienda.instance.precioPerro / 4f) * Tienda.instance.AnimalesEnT6;
                break;
            case "Pato":
                GananciasT6 += (Tienda.instance.precioPato / 4f) * Tienda.instance.AnimalesEnT6;
                break;
            case "Tigre":
                GananciasT6 += (Tienda.instance.precioTigre / 4f) * Tienda.instance.AnimalesEnT6;
                break;
            case "Zorro":
                GananciasT6 += (Tienda.instance.precioZorro / 4f) * Tienda.instance.AnimalesEnT6;
                break;
            case "Pollo":
                GananciasT6 += (Tienda.instance.precioPollo / 4f) * Tienda.instance.AnimalesEnT6;
                break;
            default:
                break;
        }
        StartCoroutine(GanarDineroT6());
    }



}

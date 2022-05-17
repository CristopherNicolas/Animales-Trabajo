using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class Tienda : MonoBehaviour
{
    bool IsOpen;
    public List<GameObject> Comprables;
    public List<GameObject> Terrenos;
    public int asignarTerreno, Gatos, Perros, Patos;
    private float precioGato, precioPerro, precioPato;
    public static Tienda instance;
    public Text Display, GatoDisplay, PerroDisplay, PatoDisplay;
    
    public void Awake()
    {
        if  (instance == null)
        {
            instance = this;
            GetComponent<RectTransform>().DOScale(0, 0);
        }
    }
    public void Start()
    {
        var contenedor = Instantiate(Comprables[0], Terrenos[0].transform.position, Terrenos[0].transform.rotation);
        contenedor.transform.parent = Terrenos[asignarTerreno].transform;
        var generarTexto = Instantiate(Display, Terrenos[0].transform.position, Terrenos[0].transform.rotation);
        generarTexto.transform.parent = Terrenos[0].transform;
        generarTexto.transform.localPosition = new Vector3(0f, -38.5f, 0f);
        generarTexto.text = "" + Gatos;
        GatoDisplay = generarTexto;
        Gatos = 1;
        TerrenoManager.instance.used1 = true;
    }

    private void FixedUpdate()
    {
        GatoCount();
        PerroCount();
        PatoCount();
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


    public void ComprarGato()
    {
        if (GameManager.instance.partidaGuardada.dinero >= precioGato)
        {
            if (GatoDisplay.text != "10" || TerrenoManager.instance.TerrenoDisponible == true)
            {
                Gatos += 1;
                GameManager.instance.partidaGuardada.dinero -= precioGato;
                if (!GatoDisplay || Gatos == 11 || Gatos == 21 || Gatos == 31 || Gatos == 41 || Gatos == 51)
                {
                    if (TerrenoManager.instance.used1 == false)
                    {
                        asignarTerreno = 0;
                        GenerarGato();
                        TerrenoManager.instance.used1 = true;
                    }
                    else
                    {
                        if (TerrenoManager.instance.used2 == false)
                        {
                            asignarTerreno = 1;
                            GenerarGato();
                            TerrenoManager.instance.used2 = true;
                        }
                        else
                        {
                            if (TerrenoManager.instance.used3 == false)
                            {
                                asignarTerreno = 2;
                                GenerarGato();
                                TerrenoManager.instance.used3 = true;
                            }
                            else
                            {
                                if (TerrenoManager.instance.used4 == false)
                                {
                                    asignarTerreno = 3;
                                    GenerarGato();
                                    TerrenoManager.instance.used4 = true;
                                }
                                else
                                {
                                    if (TerrenoManager.instance.used5 == false)
                                    {
                                        asignarTerreno = 4;
                                        GenerarGato();
                                        TerrenoManager.instance.used5 = true;
                                    }
                                    else
                                    {
                                        if (TerrenoManager.instance.used6 == false)
                                        {
                                            asignarTerreno = 5;
                                            GenerarGato();
                                            TerrenoManager.instance.used6 = true;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                CerrarTienda();
            }
            else
            {
                Debug.Log("No hay más espacio disponible");
            }
        }
        else if (GameManager.instance.partidaGuardada.dinero <= precioGato)
        {
            Debug.Log("No te queda dinero");
        }
    }
    public void ComprarPerro()
    {
        if (GameManager.instance.partidaGuardada.dinero >= precioPerro)
        {
            if (PerroDisplay.text != "10" || TerrenoManager.instance.TerrenoDisponible == true)
            {
                Perros += 1;
                GameManager.instance.partidaGuardada.dinero -= precioPerro;
                if (!PerroDisplay || Perros == 11 || Perros == 21 || Perros == 31 || Perros == 41 || Perros == 51)
                {
                    if (TerrenoManager.instance.used1 == false)
                    {
                        asignarTerreno = 0;
                        GenerarPerro();
                        TerrenoManager.instance.used1 = true;
                    }
                    else
                    {
                        if (TerrenoManager.instance.used2 == false)
                        {
                            asignarTerreno = 1;
                            GenerarPerro();
                            TerrenoManager.instance.used2 = true;
                        }
                        else
                        {
                            if (TerrenoManager.instance.used3 == false)
                            {
                                asignarTerreno = 2;
                                GenerarPerro();
                                TerrenoManager.instance.used3 = true;
                            }
                            else
                            {
                                if (TerrenoManager.instance.used4 == false)
                                {
                                    asignarTerreno = 3;
                                    GenerarPerro();
                                    TerrenoManager.instance.used4 = true;
                                }
                                else
                                {
                                    if (TerrenoManager.instance.used5 == false)
                                    {
                                        asignarTerreno = 4;
                                        GenerarPerro();
                                        TerrenoManager.instance.used5 = true;
                                    }
                                    else
                                    {
                                        if (TerrenoManager.instance.used6 == false)
                                        {
                                            asignarTerreno = 5;
                                            GenerarPerro();
                                            TerrenoManager.instance.used6 = true;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    return;
                }
                CerrarTienda();
            }
            else
            {
                Debug.Log("No hay más espacio disponible");
            }
        }
        else if (GameManager.instance.partidaGuardada.dinero <= precioPerro)
        {
            Debug.Log("No te queda dinero");
        }
    }

    public void ComprarPato()
    {
        if (GameManager.instance.partidaGuardada.dinero >= precioPato)
        {
            if (PatoDisplay.text != "10" || TerrenoManager.instance.TerrenoDisponible == true)
            {
                Patos += 1;
                GameManager.instance.partidaGuardada.dinero -= precioPato;
                if (!PatoDisplay || Patos == 11 || Patos == 21 || Patos == 31 || Patos == 41 || Patos == 51)
                {
                    if (TerrenoManager.instance.used1 == false)
                    {
                        asignarTerreno = 0;
                        GenerarPato();
                        TerrenoManager.instance.used1 = true;
                    }
                    else
                    {
                        if (TerrenoManager.instance.used2 == false)
                        {
                            asignarTerreno = 1;
                            GenerarPato();
                            TerrenoManager.instance.used2 = true;
                        }
                        else
                        {
                            if (TerrenoManager.instance.used3 == false)
                            {
                                asignarTerreno = 2;
                                GenerarPato();
                                TerrenoManager.instance.used3 = true;
                            }
                            else
                            {
                                if (TerrenoManager.instance.used4 == false)
                                {
                                    asignarTerreno = 3;
                                    GenerarPato();
                                    TerrenoManager.instance.used4 = true;
                                }
                                else
                                {
                                    if (TerrenoManager.instance.used5 == false)
                                    {
                                        asignarTerreno = 4;
                                        GenerarPato();
                                        TerrenoManager.instance.used5 = true;
                                    }
                                    else
                                    {
                                        if (TerrenoManager.instance.used6 == false)
                                        {
                                            asignarTerreno = 5;
                                            GenerarPato();
                                            TerrenoManager.instance.used6 = true;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    return;
                }
                CerrarTienda();
            }
            else
            {
                Debug.Log("No hay más espacio disponible");
            }
        }
        else if (GameManager.instance.partidaGuardada.dinero <= precioPato)
        {
            Debug.Log("No te queda dinero");
        }
    }
    public void GenerarGato()
    {
        var contenedor = Instantiate(Comprables[0], Terrenos[asignarTerreno].transform.position, Terrenos[asignarTerreno].transform.rotation);
        contenedor.transform.parent = Terrenos[asignarTerreno].transform;
        var generarTexto = Instantiate(Display, Terrenos[asignarTerreno].transform.position, Terrenos[asignarTerreno].transform.rotation);
        generarTexto.transform.parent = Terrenos[asignarTerreno].transform;
        generarTexto.transform.localPosition = new Vector3(0f, -38.5f, 0f);
        generarTexto.text = "" + Gatos;
        GatoDisplay = generarTexto;
    }
    public void GenerarPerro()
    {
        var contenedor = Instantiate(Comprables[1], Terrenos[asignarTerreno].transform.position, Terrenos[asignarTerreno].transform.rotation);
        contenedor.transform.parent = Terrenos[asignarTerreno].transform;
        var generarTexto = Instantiate(Display, Terrenos[asignarTerreno].transform.position, Terrenos[asignarTerreno].transform.rotation);
        generarTexto.transform.parent = Terrenos[asignarTerreno].transform;
        generarTexto.transform.localPosition = new Vector3(0f, -38.5f, 0f);
        generarTexto.text = "" + Perros;
        PerroDisplay = generarTexto;
    }
    public void GenerarPato()
    {
        var contenedor = Instantiate(Comprables[2], Terrenos[asignarTerreno].transform.position, Terrenos[asignarTerreno].transform.rotation);
        contenedor.transform.parent = Terrenos[asignarTerreno].transform;
        var generarTexto = Instantiate(Display, Terrenos[asignarTerreno].transform.position, Terrenos[asignarTerreno].transform.rotation);
        generarTexto.transform.parent = Terrenos[asignarTerreno].transform;
        generarTexto.transform.localPosition = new Vector3(0f, -38.5f, 0f);
        generarTexto.text = "" + Patos;
        PatoDisplay = generarTexto;
    }
    private void GatoCount()
    {
        if (GatoDisplay)
        {
            switch (Gatos > 10, Gatos > 20, Gatos > 30, Gatos > 40, Gatos > 50)
            {
                case (true, false, false, false, false):
                    GatoDisplay.text = "" + (Gatos - 10);
                    break;
                case (true, true, false, false, false):
                    GatoDisplay.text = "" + (Gatos - 20);
                    break;
                case (true, true, true, false, false):
                    GatoDisplay.text = "" + (Gatos - 30);
                    break;
                case (true, true, true, true, false):
                    GatoDisplay.text = "" + (Gatos - 40);
                    break;
                case (true, true, true, true, true):
                    GatoDisplay.text = "" + (Gatos - 50);
                    break;
                default:
                    GatoDisplay.text = "" + Gatos;
                    break;
            }
        }
    }
    private void PerroCount()
    {
        if (PerroDisplay)
        {
            switch (Perros > 10, Perros > 20, Perros > 30, Perros > 40, Perros > 50)
            {
                case (true,false,false,false,false):
                    PerroDisplay.text = "" + (Perros - 10);
                    break;
                case (true, true, false, false, false):
                    PerroDisplay.text = "" + (Perros - 20);
                    break;
                case (true, true, true, false, false):
                    PerroDisplay.text = "" + (Perros - 30);
                    break;
                case (true, true, true, true, false):
                    PerroDisplay.text = "" + (Perros - 40);
                    break;
                case (true, true, true, true, true):
                    PerroDisplay.text = "" + (Perros - 50);
                    break;
                default:
                    PerroDisplay.text = "" + Perros;
                    break;
            }
        }
    }
    private void PatoCount()
    {
        if (PatoDisplay)
        {
            switch (Patos > 10, Patos > 20, Patos > 30, Patos > 40, Patos > 50)
            {
                case (true, false, false, false, false):
                    PatoDisplay.text = "" + (Patos - 10);
                    break;
                case (true, true, false, false, false):
                    PatoDisplay.text = "" + (Patos - 20);
                    break;
                case (true, true, true, false, false):
                    PatoDisplay.text = "" + (Patos - 30);
                    break;
                case (true, true, true, true, false):
                    PatoDisplay.text = "" + (Patos - 40);
                    break;
                case (true, true, true, true, true):
                    PatoDisplay.text = "" + (Patos - 50);
                    break;
                default:
                    PatoDisplay.text = "" + Patos;
                    break;
            }
        }
    }
}

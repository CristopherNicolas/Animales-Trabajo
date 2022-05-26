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
    public int asignarTerreno, Gatos, Perros, Patos, Tigres, Zorros, Pollos;
    public float precioGato, precioPerro, precioPato, precioTigre, precioZorro, precioPollo;
    public static Tienda instance;
    public Text Display, GatoDisplay, PerroDisplay, PatoDisplay,TigreDisplay,ZorroDisplay,PolloDisplay;
    
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
        TigreCount();
        ZorroCount();
        PolloCount();
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

    //Botones de compra:
    public void ComprarGato()
    {
        if ((Gatos == 0 || Gatos == 10 || Gatos == 20 || Gatos == 30 || Gatos == 40 || Gatos == 50 || Gatos == 60) && TerrenoManager.instance.TerrenoDisponible == false)
        {
            Debug.Log("No hay Terreno disponible");
        }
        else
        {
            if (GameManager.instance.partidaGuardada.dinero >= precioGato)
            {
                Gatos += 1;
                if (Gatos == 1 || Gatos == 11 || Gatos == 21 || Gatos == 31 || Gatos == 41 || Gatos == 51)
                {
                    if (TerrenoManager.instance.used1 == false)
                    {
                        asignarTerreno = 0;
                        GenerarGato();
                        TerrenoManager.instance.used1 = true;
                        Terreno.instance.AnimalTerreno1 = "Gato";
                    }
                    else
                    {
                        if (TerrenoManager.instance.used2 == false)
                        {
                            asignarTerreno = 1;
                            GenerarGato();
                            TerrenoManager.instance.used2 = true;
                            Terreno.instance.AnimalTerreno2 = "Gato";
                        }
                        else
                        {
                            if (TerrenoManager.instance.used3 == false)
                            {
                                asignarTerreno = 2;
                                GenerarGato();
                                TerrenoManager.instance.used3 = true;
                                Terreno.instance.AnimalTerreno3 = "Gato";
                            }
                            else
                            {
                                if (TerrenoManager.instance.used4 == false)
                                {
                                    asignarTerreno = 3;
                                    GenerarGato();
                                    TerrenoManager.instance.used4 = true;
                                    Terreno.instance.AnimalTerreno4 = "Gato";
                                }
                                else
                                {
                                    if (TerrenoManager.instance.used5 == false)
                                    {
                                        asignarTerreno = 4;
                                        GenerarGato();
                                        TerrenoManager.instance.used5 = true;
                                        Terreno.instance.AnimalTerreno5 = "Gato";
                                    }
                                    else
                                    {
                                        if (TerrenoManager.instance.used6 == false)
                                        {
                                            asignarTerreno = 5;
                                            GenerarGato();
                                            TerrenoManager.instance.used6 = true;
                                            Terreno.instance.AnimalTerreno6 = "Gato";
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                GameManager.instance.partidaGuardada.dinero -= precioGato;
                CerrarTienda();
            }
            else
            {
                Debug.Log("No te queda dinero");
            }
        }
    }
    public void ComprarPerro()
    {
        if ((Perros == 0 || Perros == 10 || Perros == 20 || Perros == 30 || Perros == 40 || Perros == 50 || Perros == 60) && TerrenoManager.instance.TerrenoDisponible == false)
        {
            Debug.Log("No hay Terreno disponible");
        }
        else
        {
            if (GameManager.instance.partidaGuardada.dinero >= precioPerro)
            {
                Perros += 1;
                if (Perros == 1 || Perros == 11 || Perros == 21 || Perros == 31 || Perros == 41 || Perros == 51)
                {
                    if (TerrenoManager.instance.used1 == false)
                    {
                        asignarTerreno = 0;
                        GenerarPerro();
                        TerrenoManager.instance.used1 = true;
                        Terreno.instance.AnimalTerreno1 = "Perro";
                    }
                    else
                    {
                        if (TerrenoManager.instance.used2 == false)
                        {
                            asignarTerreno = 1;
                            GenerarPerro();
                            TerrenoManager.instance.used2 = true;
                            Terreno.instance.AnimalTerreno2 = "Perro";
                        }
                        else
                        {
                            if (TerrenoManager.instance.used3 == false)
                            {
                                asignarTerreno = 2;
                                GenerarPerro();
                                TerrenoManager.instance.used3 = true;
                                Terreno.instance.AnimalTerreno3 = "Perro";
                            }
                            else
                            {
                                if (TerrenoManager.instance.used4 == false)
                                {
                                    asignarTerreno = 3;
                                    GenerarPerro();
                                    TerrenoManager.instance.used4 = true;
                                    Terreno.instance.AnimalTerreno4 = "Perro";
                                }
                                else
                                {
                                    if (TerrenoManager.instance.used5 == false)
                                    {
                                        asignarTerreno = 4;
                                        GenerarPerro();
                                        TerrenoManager.instance.used5 = true;
                                        Terreno.instance.AnimalTerreno5 = "Perro";
                                    }
                                    else
                                    {
                                        if (TerrenoManager.instance.used6 == false)
                                        {
                                            asignarTerreno = 5;
                                            GenerarPerro();
                                            TerrenoManager.instance.used6 = true;
                                            Terreno.instance.AnimalTerreno6 = "Perro";
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                GameManager.instance.partidaGuardada.dinero -= precioPerro;
                CerrarTienda();
            }
            else
            {
                Debug.Log("No te queda dinero");
            }
        }
    }
    public void ComprarPato()
    {
        if ((Patos == 0 || Patos == 10 || Patos == 20 || Patos == 30 || Patos == 40 || Patos == 50 || Patos == 60) && TerrenoManager.instance.TerrenoDisponible == false)
        {
            Debug.Log("No hay Terreno disponible");
        }
        else
        {
            if (GameManager.instance.partidaGuardada.dinero >= precioPato)
            {
                Patos += 1;
                if (Patos == 1 || Patos == 11 || Patos == 21 || Patos == 31 || Patos == 41 || Patos == 51)
                {
                    if (TerrenoManager.instance.used1 == false)
                    {
                        asignarTerreno = 0;
                        GenerarPato();
                        TerrenoManager.instance.used1 = true;
                        Terreno.instance.AnimalTerreno1 = "Pato";
                    }
                    else
                    {
                        if (TerrenoManager.instance.used2 == false)
                        {
                            asignarTerreno = 1;
                            GenerarPato();
                            TerrenoManager.instance.used2 = true;
                            Terreno.instance.AnimalTerreno2 = "Pato";
                        }
                        else
                        {
                            if (TerrenoManager.instance.used3 == false)
                            {
                                asignarTerreno = 2;
                                GenerarPato();
                                TerrenoManager.instance.used3 = true;
                                Terreno.instance.AnimalTerreno3 = "Pato";
                            }
                            else
                            {
                                if (TerrenoManager.instance.used4 == false)
                                {
                                    asignarTerreno = 3;
                                    GenerarPato();
                                    TerrenoManager.instance.used4 = true;
                                    Terreno.instance.AnimalTerreno4 = "Pato";
                                }
                                else
                                {
                                    if (TerrenoManager.instance.used5 == false)
                                    {
                                        asignarTerreno = 4;
                                        GenerarPato();
                                        TerrenoManager.instance.used5 = true;
                                        Terreno.instance.AnimalTerreno5 = "Pato";
                                    }
                                    else
                                    {
                                        if (TerrenoManager.instance.used6 == false)
                                        {
                                            asignarTerreno = 5;
                                            GenerarPato();
                                            TerrenoManager.instance.used6 = true;
                                            Terreno.instance.AnimalTerreno6 = "Pato";
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                GameManager.instance.partidaGuardada.dinero -= precioPato;
                CerrarTienda();
            }
            else
            {
                Debug.Log("No te queda dinero");
            }
        }
    }
    public void ComprarTigre()
    {
        if ((Tigres == 0 || Tigres == 10 || Tigres == 20 || Tigres == 30 || Tigres == 40 || Tigres == 50 || Tigres == 60) && TerrenoManager.instance.TerrenoDisponible == false)
        {
            Debug.Log("No hay Terreno disponible");
        }
        else
        {
            if (GameManager.instance.partidaGuardada.dinero >= precioTigre)
            {
                Tigres += 1;
                if (Tigres == 1 || Tigres == 11 || Tigres == 21 || Tigres == 31 || Tigres == 41 || Tigres == 51)
                {
                    if (TerrenoManager.instance.used1 == false)
                    {
                        asignarTerreno = 0;
                        GenerarTigre();
                        TerrenoManager.instance.used1 = true;
                        Terreno.instance.AnimalTerreno1 = "Tigre";
                    }
                    else
                    {
                        if (TerrenoManager.instance.used2 == false)
                        {
                            asignarTerreno = 1;
                            GenerarTigre();
                            TerrenoManager.instance.used2 = true;
                            Terreno.instance.AnimalTerreno2 = "Tigre";
                        }
                        else
                        {
                            if (TerrenoManager.instance.used3 == false)
                            {
                                asignarTerreno = 2;
                                GenerarTigre();
                                TerrenoManager.instance.used3 = true;
                                Terreno.instance.AnimalTerreno3 = "Tigre";
                            }
                            else
                            {
                                if (TerrenoManager.instance.used4 == false)
                                {
                                    asignarTerreno = 3;
                                    GenerarTigre();
                                    TerrenoManager.instance.used4 = true;
                                    Terreno.instance.AnimalTerreno4 = "Tigre";
                                }
                                else
                                {
                                    if (TerrenoManager.instance.used5 == false)
                                    {
                                        asignarTerreno = 4;
                                        GenerarTigre();
                                        TerrenoManager.instance.used5 = true;
                                        Terreno.instance.AnimalTerreno5 = "Tigre";
                                    }
                                    else
                                    {
                                        if (TerrenoManager.instance.used6 == false)
                                        {
                                            asignarTerreno = 5;
                                            GenerarTigre();
                                            TerrenoManager.instance.used6 = true;
                                            Terreno.instance.AnimalTerreno6 = "Tigre";
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                GameManager.instance.partidaGuardada.dinero -= precioTigre;
                CerrarTienda();
            }
            else
            {
                Debug.Log("No te queda dinero");
            }
        }
    }
    public void ComprarZorro()
    {
        if ((Zorros == 0 || Zorros == 10 || Zorros == 20 || Zorros == 30 || Zorros == 40 || Zorros == 50 || Zorros == 60) && TerrenoManager.instance.TerrenoDisponible == false)
        {
            Debug.Log("No hay Terreno disponible");
        }
        else
        {
            if (GameManager.instance.partidaGuardada.dinero >= precioZorro)
            {
                Zorros += 1;
                if (Zorros == 1 || Zorros == 11 || Zorros == 21 || Zorros == 31 || Zorros == 41 || Zorros == 51)
                {
                    if (TerrenoManager.instance.used1 == false)
                    {
                        asignarTerreno = 0;
                        GenerarZorro();
                        TerrenoManager.instance.used1 = true;
                        Terreno.instance.AnimalTerreno1 = "Zorro";
                    }
                    else
                    {
                        if (TerrenoManager.instance.used2 == false)
                        {
                            asignarTerreno = 1;
                            GenerarZorro();
                            TerrenoManager.instance.used2 = true;
                            Terreno.instance.AnimalTerreno2 = "Zorro";
                        }
                        else
                        {
                            if (TerrenoManager.instance.used3 == false)
                            {
                                asignarTerreno = 2;
                                GenerarZorro();
                                TerrenoManager.instance.used3 = true;
                                Terreno.instance.AnimalTerreno3 = "Zorro";
                            }
                            else
                            {
                                if (TerrenoManager.instance.used4 == false)
                                {
                                    asignarTerreno = 3;
                                    GenerarZorro();
                                    TerrenoManager.instance.used4 = true;
                                    Terreno.instance.AnimalTerreno4 = "Zorro";
                                }
                                else
                                {
                                    if (TerrenoManager.instance.used5 == false)
                                    {
                                        asignarTerreno = 4;
                                        GenerarZorro();
                                        TerrenoManager.instance.used5 = true;
                                        Terreno.instance.AnimalTerreno5 = "Zorro";
                                    }
                                    else
                                    {
                                        if (TerrenoManager.instance.used6 == false)
                                        {
                                            asignarTerreno = 5;
                                            GenerarZorro();
                                            TerrenoManager.instance.used6 = true;
                                            Terreno.instance.AnimalTerreno6 = "Zorro";
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                GameManager.instance.partidaGuardada.dinero -= precioZorro;
                CerrarTienda();
            }
            else
            {
                Debug.Log("No te queda dinero");
            }
        }
    }
    public void ComprarPollo()
    {
        if ((Pollos == 0 || Pollos == 10 || Pollos == 20 || Pollos == 30 || Pollos == 40 || Pollos == 50 || Pollos == 60) && TerrenoManager.instance.TerrenoDisponible == false)
        {
            Debug.Log("No hay Terreno disponible");
        }
        else
        {
            if (GameManager.instance.partidaGuardada.dinero >= precioPollo)
            {
                Pollos += 1;
                if (Pollos == 1 || Pollos == 11 || Pollos == 21 || Pollos == 31 || Pollos == 41 || Pollos == 51)
                {
                    if (TerrenoManager.instance.used1 == false)
                    {
                        asignarTerreno = 0;
                        GenerarPollo();
                        TerrenoManager.instance.used1 = true;
                        Terreno.instance.AnimalTerreno1 = "Pollo";
                    }
                    else
                    {
                        if (TerrenoManager.instance.used2 == false)
                        {
                            asignarTerreno = 1;
                            GenerarPollo();
                            TerrenoManager.instance.used2 = true;
                            Terreno.instance.AnimalTerreno2 = "Pollo";
                        }
                        else
                        {
                            if (TerrenoManager.instance.used3 == false)
                            {
                                asignarTerreno = 2;
                                GenerarPollo();
                                TerrenoManager.instance.used3 = true;
                                Terreno.instance.AnimalTerreno3 = "Pollo";
                            }
                            else
                            {
                                if (TerrenoManager.instance.used4 == false)
                                {
                                    asignarTerreno = 3;
                                    GenerarPollo();
                                    TerrenoManager.instance.used4 = true;
                                    Terreno.instance.AnimalTerreno4 = "Pollo";
                                }
                                else
                                {
                                    if (TerrenoManager.instance.used5 == false)
                                    {
                                        asignarTerreno = 4;
                                        GenerarPollo();
                                        TerrenoManager.instance.used5 = true;
                                        Terreno.instance.AnimalTerreno5 = "Pollo";
                                    }
                                    else
                                    {
                                        if (TerrenoManager.instance.used6 == false)
                                        {
                                            asignarTerreno = 5;
                                            GenerarPollo();
                                            TerrenoManager.instance.used6 = true;
                                            Terreno.instance.AnimalTerreno6 = "Pollo";
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                GameManager.instance.partidaGuardada.dinero -= precioPollo;
                CerrarTienda();
            }
            else
            {
                Debug.Log("No te queda dinero");
            }
        }
    }

    //Generadores de Animales:
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
    public void GenerarTigre()
    {
        var contenedor = Instantiate(Comprables[3], Terrenos[asignarTerreno].transform.position, Terrenos[asignarTerreno].transform.rotation);
        contenedor.transform.parent = Terrenos[asignarTerreno].transform;
        var generarTexto = Instantiate(Display, Terrenos[asignarTerreno].transform.position, Terrenos[asignarTerreno].transform.rotation);
        generarTexto.transform.parent = Terrenos[asignarTerreno].transform;
        generarTexto.transform.localPosition = new Vector3(0f, -38.5f, 0f);
        generarTexto.text = "" + Tigres;
        TigreDisplay = generarTexto;
    }
    public void GenerarZorro()
    {
        var contenedor = Instantiate(Comprables[4], Terrenos[asignarTerreno].transform.position, Terrenos[asignarTerreno].transform.rotation);
        contenedor.transform.parent = Terrenos[asignarTerreno].transform;
        var generarTexto = Instantiate(Display, Terrenos[asignarTerreno].transform.position, Terrenos[asignarTerreno].transform.rotation);
        generarTexto.transform.parent = Terrenos[asignarTerreno].transform;
        generarTexto.transform.localPosition = new Vector3(0f, -38.5f, 0f);
        generarTexto.text = "" + Zorros;
        ZorroDisplay = generarTexto;
    }
    public void GenerarPollo()
    {
        var contenedor = Instantiate(Comprables[5], Terrenos[asignarTerreno].transform.position, Terrenos[asignarTerreno].transform.rotation);
        contenedor.transform.parent = Terrenos[asignarTerreno].transform;
        var generarTexto = Instantiate(Display, Terrenos[asignarTerreno].transform.position, Terrenos[asignarTerreno].transform.rotation);
        generarTexto.transform.parent = Terrenos[asignarTerreno].transform;
        generarTexto.transform.localPosition = new Vector3(0f, -38.5f, 0f);
        generarTexto.text = "" + Pollos;
        PolloDisplay = generarTexto;
    }

    //Contadores de Animales:
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
    private void TigreCount()
    {
        if (TigreDisplay)
        {
            switch (Tigres > 10, Tigres > 20, Tigres > 30, Tigres > 40, Tigres > 50)
            {
                case (true, false, false, false, false):
                    TigreDisplay.text = "" + (Tigres - 10);
                    break;
                case (true, true, false, false, false):
                    TigreDisplay.text = "" + (Tigres - 20);
                    break;
                case (true, true, true, false, false):
                    TigreDisplay.text = "" + (Tigres - 30);
                    break;
                case (true, true, true, true, false):
                    TigreDisplay.text = "" + (Tigres - 40);
                    break;
                case (true, true, true, true, true):
                    TigreDisplay.text = "" + (Tigres - 50);
                    break;
                default:
                    TigreDisplay.text = "" + Tigres;
                    break;
            }
        }
    }
    private void ZorroCount() 
    {
        if (ZorroDisplay)
        {
            switch (Zorros > 10, Zorros > 20, Zorros > 30, Zorros > 40, Zorros > 50)
            {
                case (true, false, false, false, false):
                    ZorroDisplay.text = "" + (Zorros - 10);
                    break;
                case (true, true, false, false, false):
                    ZorroDisplay.text = "" + (Zorros - 20);
                    break;
                case (true, true, true, false, false):
                    ZorroDisplay.text = "" + (Zorros - 30);
                    break;
                case (true, true, true, true, false):
                    ZorroDisplay.text = "" + (Zorros - 40);
                    break;
                case (true, true, true, true, true):
                    ZorroDisplay.text = "" + (Zorros - 50);
                    break;
                default:
                    ZorroDisplay.text = "" + Zorros;
                    break;
            }
        }
    }
    private void PolloCount()
    {
        if (PolloDisplay)
        {
            switch (Pollos > 10, Pollos > 20, Pollos > 30, Pollos > 40, Pollos > 50)
            {
                case (true, false, false, false, false):
                    PolloDisplay.text = "" + (Pollos - 10);
                    break;
                case (true, true, false, false, false):
                    PolloDisplay.text = "" + (Pollos - 20);
                    break;
                case (true, true, true, false, false):
                    PolloDisplay.text = "" + (Pollos - 30);
                    break;
                case (true, true, true, true, false):
                    PolloDisplay.text = "" + (Pollos - 40);
                    break;
                case (true, true, true, true, true):
                    PolloDisplay.text = "" + (Pollos - 50);
                    break;
                default:
                    PolloDisplay.text = "" + Pollos;
                    break;
            }
        }
    }

}

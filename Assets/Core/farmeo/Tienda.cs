using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class Tienda : MonoBehaviour
{
    public bool IsOpen, IsFull;
    public List<GameObject> Comprables;
    public List<GameObject> Terrenos;
    public int asignarTerreno, AnimalesEnT1, AnimalesEnT2, AnimalesEnT3, AnimalesEnT4, AnimalesEnT5, AnimalesEnT6;
    public float precioGato, precioPerro, precioPato, precioTigre, precioZorro, precioPollo;
    public static Tienda instance;
    
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
        contenedor.transform.parent = Terrenos[0].transform;
        AnimalesEnT1 = 1;
        TerrenoManager.instance.used1 = true;
        TerrenoManager.instance.AnimalTerreno1 = "Gato";
        TerrenoManager.instance.AnimalSprite1 = contenedor;
    }
    public void FixedUpdate()
    {
        EspacioDisponible();
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
        if (IsFull == true && TerrenoManager.instance.TerrenoDisponible == false)
        {
            Debug.Log("No tienes espacio disponible.");
        }
        else
        {
            if (GameManager.instance.partidaGuardada.dinero >= precioGato)
            {
                if (AnimalesEnT1 == 0)
                {
                    asignarTerreno = 0;
                    AnimalesEnT1 += 1;
                    var contenedor = Instantiate(Comprables[0], Terrenos[asignarTerreno].transform.position, Terrenos[asignarTerreno].transform.rotation);
                    contenedor.transform.parent = Terrenos[asignarTerreno].transform;
                    TerrenoManager.instance.AnimalSprite1 = contenedor;
                    TerrenoManager.instance.used1 = true;
                    TerrenoManager.instance.AnimalTerreno1 = "Gato";
                    GameManager.instance.partidaGuardada.dinero -= precioGato;
                }
                else if (AnimalesEnT1 < 10 && TerrenoManager.instance.AnimalTerreno1 == "Gato")
                {
                    AnimalesEnT1 += 1;
                    GameManager.instance.partidaGuardada.dinero -= precioGato;
                }
                else
                {
                    if (AnimalesEnT2 == 0)
                    {
                        asignarTerreno = 1;
                        AnimalesEnT2 += 1;
                        var contenedor = Instantiate(Comprables[0], Terrenos[asignarTerreno].transform.position, Terrenos[asignarTerreno].transform.rotation);
                        contenedor.transform.parent = Terrenos[asignarTerreno].transform;
                        TerrenoManager.instance.AnimalSprite2 = contenedor;
                        TerrenoManager.instance.used2 = true;
                        TerrenoManager.instance.AnimalTerreno2 = "Gato";
                        GameManager.instance.partidaGuardada.dinero -= precioGato;
                    }
                    else if (AnimalesEnT2 < 10 && TerrenoManager.instance.AnimalTerreno2 == "Gato")
                    {
                        AnimalesEnT2 += 1;
                        GameManager.instance.partidaGuardada.dinero -= precioGato;
                    }
                    else
                    {
                        if (AnimalesEnT3 == 0)
                        {
                            asignarTerreno = 2;
                            AnimalesEnT3 += 1;
                            var contenedor = Instantiate(Comprables[0], Terrenos[asignarTerreno].transform.position, Terrenos[asignarTerreno].transform.rotation);
                            contenedor.transform.parent = Terrenos[asignarTerreno].transform;
                            TerrenoManager.instance.AnimalSprite3 = contenedor;
                            TerrenoManager.instance.used3 = true;
                            TerrenoManager.instance.AnimalTerreno3 = "Gato";
                            GameManager.instance.partidaGuardada.dinero -= precioGato;
                        }
                        else if (AnimalesEnT3 < 10 && TerrenoManager.instance.AnimalTerreno3 == "Gato")
                        {
                            AnimalesEnT3 += 1;
                            GameManager.instance.partidaGuardada.dinero -= precioGato;
                        }
                        else
                        {
                            if (AnimalesEnT4 == 0)
                            {
                                asignarTerreno = 3;
                                AnimalesEnT4 += 1;
                                var contenedor = Instantiate(Comprables[0], Terrenos[asignarTerreno].transform.position, Terrenos[asignarTerreno].transform.rotation);
                                contenedor.transform.parent = Terrenos[asignarTerreno].transform;
                                TerrenoManager.instance.AnimalSprite4 = contenedor;
                                TerrenoManager.instance.used4 = true;
                                TerrenoManager.instance.AnimalTerreno4 = "Gato";
                                GameManager.instance.partidaGuardada.dinero -= precioGato;
                            }
                            else if (AnimalesEnT4 < 10 && TerrenoManager.instance.AnimalTerreno4 == "Gato")
                            {
                                AnimalesEnT4 += 1;
                                GameManager.instance.partidaGuardada.dinero -= precioGato;
                            }
                            else
                            {
                                if (AnimalesEnT5 == 0)
                                {
                                    asignarTerreno = 4;
                                    AnimalesEnT5 += 1;
                                    var contenedor = Instantiate(Comprables[0], Terrenos[asignarTerreno].transform.position, Terrenos[asignarTerreno].transform.rotation);
                                    contenedor.transform.parent = Terrenos[asignarTerreno].transform;
                                    TerrenoManager.instance.AnimalSprite5 = contenedor;
                                    TerrenoManager.instance.used5 = true;
                                    TerrenoManager.instance.AnimalTerreno5 = "Gato";
                                    GameManager.instance.partidaGuardada.dinero -= precioGato;
                                }
                                else if (AnimalesEnT5 < 10 && TerrenoManager.instance.AnimalTerreno5 == "Gato")
                                {
                                    AnimalesEnT5 += 1;
                                    GameManager.instance.partidaGuardada.dinero -= precioGato;
                                }
                                else
                                {
                                    if (AnimalesEnT6 == 0)
                                    {
                                        asignarTerreno = 5;
                                        AnimalesEnT6 += 1;
                                        var contenedor = Instantiate(Comprables[0], Terrenos[asignarTerreno].transform.position, Terrenos[asignarTerreno].transform.rotation);
                                        contenedor.transform.parent = Terrenos[asignarTerreno].transform;
                                        TerrenoManager.instance.AnimalSprite6 = contenedor;
                                        TerrenoManager.instance.used6 = true;
                                        TerrenoManager.instance.AnimalTerreno6 = "Gato";
                                        GameManager.instance.partidaGuardada.dinero -= precioGato;
                                    }
                                    else if (AnimalesEnT6 < 10 && TerrenoManager.instance.AnimalTerreno6 == "Gato")
                                    {
                                        AnimalesEnT6 += 1;
                                        GameManager.instance.partidaGuardada.dinero -= precioGato;
                                    }
                                    else
                                    {
                                        Debug.Log("No tienes espacio disponible");
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
                Debug.Log("No tienes dinero suficiente");
            }
        }
    }
    public void ComprarPerro()
    {
        if (IsFull == true && TerrenoManager.instance.TerrenoDisponible == false)
        {
            Debug.Log("No tienes espacio disponible.");
        }
        else
        {
            if (GameManager.instance.partidaGuardada.dinero >= precioPerro)
            {
                if (AnimalesEnT1 == 0)
                {
                    asignarTerreno = 0;
                    AnimalesEnT1 += 1;
                    var contenedor = Instantiate(Comprables[1], Terrenos[asignarTerreno].transform.position, Terrenos[asignarTerreno].transform.rotation);
                    contenedor.transform.parent = Terrenos[asignarTerreno].transform;
                    TerrenoManager.instance.AnimalSprite1 = contenedor;
                    TerrenoManager.instance.used1 = true;
                    TerrenoManager.instance.AnimalTerreno1 = "Perro";
                    GameManager.instance.partidaGuardada.dinero -= precioPerro;
                }
                else if (AnimalesEnT1 < 10 && TerrenoManager.instance.AnimalTerreno1 == "Perro")
                {
                    AnimalesEnT1 += 1;
                    GameManager.instance.partidaGuardada.dinero -= precioPerro;
                }
                else
                {
                    if (AnimalesEnT2 == 0)
                    {
                        asignarTerreno = 1;
                        AnimalesEnT2 += 1;
                        var contenedor = Instantiate(Comprables[1], Terrenos[asignarTerreno].transform.position, Terrenos[asignarTerreno].transform.rotation);
                        contenedor.transform.parent = Terrenos[asignarTerreno].transform;
                        TerrenoManager.instance.AnimalSprite2 = contenedor;
                        TerrenoManager.instance.used2 = true;
                        TerrenoManager.instance.AnimalTerreno2 = "Perro";
                        GameManager.instance.partidaGuardada.dinero -= precioPerro;
                    }
                    else if (AnimalesEnT2 < 10 && TerrenoManager.instance.AnimalTerreno2 == "Perro")
                    {
                        AnimalesEnT2 += 1;
                        GameManager.instance.partidaGuardada.dinero -= precioPerro;
                    }
                    else
                    {
                        if (AnimalesEnT3 == 0)
                        {
                            asignarTerreno = 2;
                            AnimalesEnT3 += 1;
                            var contenedor = Instantiate(Comprables[1], Terrenos[asignarTerreno].transform.position, Terrenos[asignarTerreno].transform.rotation);
                            contenedor.transform.parent = Terrenos[asignarTerreno].transform;
                            TerrenoManager.instance.AnimalSprite3 = contenedor;
                            TerrenoManager.instance.used3 = true;
                            TerrenoManager.instance.AnimalTerreno3 = "Perro";
                            GameManager.instance.partidaGuardada.dinero -= precioPerro;
                        }
                        else if (AnimalesEnT3 < 10 && TerrenoManager.instance.AnimalTerreno3 == "Perro")
                        {
                            AnimalesEnT3 += 1;
                            GameManager.instance.partidaGuardada.dinero -= precioPerro;
                        }
                        else
                        {
                            if (AnimalesEnT4 == 0)
                            {
                                asignarTerreno = 3;
                                AnimalesEnT4 += 1;
                                var contenedor = Instantiate(Comprables[1], Terrenos[asignarTerreno].transform.position, Terrenos[asignarTerreno].transform.rotation);
                                contenedor.transform.parent = Terrenos[asignarTerreno].transform;
                                TerrenoManager.instance.AnimalSprite4 = contenedor;
                                TerrenoManager.instance.used4 = true;
                                TerrenoManager.instance.AnimalTerreno4 = "Perro";
                                GameManager.instance.partidaGuardada.dinero -= precioPerro;
                            }
                            else if (AnimalesEnT4 < 10 && TerrenoManager.instance.AnimalTerreno4 == "Perro")
                            {
                                AnimalesEnT4 += 1;
                                GameManager.instance.partidaGuardada.dinero -= precioPerro;
                            }
                            else
                            {
                                if (AnimalesEnT5 == 0)
                                {
                                    asignarTerreno = 4;
                                    AnimalesEnT5 += 1;
                                    var contenedor = Instantiate(Comprables[1], Terrenos[asignarTerreno].transform.position, Terrenos[asignarTerreno].transform.rotation);
                                    contenedor.transform.parent = Terrenos[asignarTerreno].transform;
                                    TerrenoManager.instance.AnimalSprite5 = contenedor;
                                    TerrenoManager.instance.used5 = true;
                                    TerrenoManager.instance.AnimalTerreno5 = "Perro";
                                    GameManager.instance.partidaGuardada.dinero -= precioPerro;
                                }
                                else if (AnimalesEnT5 < 10 && TerrenoManager.instance.AnimalTerreno5 == "Perro")
                                {
                                    AnimalesEnT5 += 1;
                                    GameManager.instance.partidaGuardada.dinero -= precioPerro;
                                }
                                else
                                {
                                    if (AnimalesEnT6 == 0)
                                    {
                                        asignarTerreno = 5;
                                        AnimalesEnT6 += 1;
                                        var contenedor = Instantiate(Comprables[1], Terrenos[asignarTerreno].transform.position, Terrenos[asignarTerreno].transform.rotation);
                                        contenedor.transform.parent = Terrenos[asignarTerreno].transform;
                                        TerrenoManager.instance.AnimalSprite6 = contenedor;
                                        TerrenoManager.instance.used6 = true;
                                        TerrenoManager.instance.AnimalTerreno6 = "Perro";
                                        GameManager.instance.partidaGuardada.dinero -= precioPerro;
                                    }
                                    else if (AnimalesEnT6 < 10 && TerrenoManager.instance.AnimalTerreno6 == "Perro")
                                    {
                                        AnimalesEnT6 += 1;
                                        GameManager.instance.partidaGuardada.dinero -= precioPerro;
                                    }
                                    else
                                    {
                                        Debug.Log("No tienes espacio disponible");
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
                Debug.Log("No tienes dinero suficiente");
            }
        }
    }
    public void ComprarPato()
    {
        if (IsFull == true && TerrenoManager.instance.TerrenoDisponible == false)
        {
            Debug.Log("No tienes espacio disponible.");
        }
        else
        {
            if (GameManager.instance.partidaGuardada.dinero >= precioPato)
            {
                if (AnimalesEnT1 == 0)
                {
                    asignarTerreno = 0;
                    AnimalesEnT1 += 1;
                    var contenedor = Instantiate(Comprables[2], Terrenos[asignarTerreno].transform.position, Terrenos[asignarTerreno].transform.rotation);
                    contenedor.transform.parent = Terrenos[asignarTerreno].transform;
                    TerrenoManager.instance.AnimalSprite1 = contenedor;
                    TerrenoManager.instance.used1 = true;
                    TerrenoManager.instance.AnimalTerreno1 = "Pato";
                    GameManager.instance.partidaGuardada.dinero -= precioPato;
                }
                else if (AnimalesEnT1 < 10 && TerrenoManager.instance.AnimalTerreno1 == "Pato")
                {
                    AnimalesEnT1 += 1;
                    GameManager.instance.partidaGuardada.dinero -= precioPato;
                }
                else
                {
                    if (AnimalesEnT2 == 0)
                    {
                        asignarTerreno = 1;
                        AnimalesEnT2 += 1;
                        var contenedor = Instantiate(Comprables[2], Terrenos[asignarTerreno].transform.position, Terrenos[asignarTerreno].transform.rotation);
                        contenedor.transform.parent = Terrenos[asignarTerreno].transform;
                        TerrenoManager.instance.AnimalSprite2 = contenedor;
                        TerrenoManager.instance.used2 = true;
                        TerrenoManager.instance.AnimalTerreno2 = "Pato";
                        GameManager.instance.partidaGuardada.dinero -= precioPato;
                    }
                    else if (AnimalesEnT2 < 10 && TerrenoManager.instance.AnimalTerreno2 == "Pato")
                    {
                        AnimalesEnT2 += 1;
                        GameManager.instance.partidaGuardada.dinero -= precioPato;
                    }
                    else
                    {
                        if (AnimalesEnT3 == 0)
                        {
                            asignarTerreno = 2;
                            AnimalesEnT3 += 1;
                            var contenedor = Instantiate(Comprables[2], Terrenos[asignarTerreno].transform.position, Terrenos[asignarTerreno].transform.rotation);
                            contenedor.transform.parent = Terrenos[asignarTerreno].transform;
                            TerrenoManager.instance.AnimalSprite3 = contenedor;
                            TerrenoManager.instance.used3 = true;
                            TerrenoManager.instance.AnimalTerreno3 = "Pato";
                            GameManager.instance.partidaGuardada.dinero -= precioPato;
                        }
                        else if (AnimalesEnT3 < 10 && TerrenoManager.instance.AnimalTerreno3 == "Pato")
                        {
                            AnimalesEnT3 += 1;
                            GameManager.instance.partidaGuardada.dinero -= precioPato;
                        }
                        else
                        {
                            if (AnimalesEnT4 == 0)
                            {
                                asignarTerreno = 3;
                                AnimalesEnT4 += 1;
                                var contenedor = Instantiate(Comprables[2], Terrenos[asignarTerreno].transform.position, Terrenos[asignarTerreno].transform.rotation);
                                contenedor.transform.parent = Terrenos[asignarTerreno].transform;
                                TerrenoManager.instance.AnimalSprite4 = contenedor;
                                TerrenoManager.instance.used4 = true;
                                TerrenoManager.instance.AnimalTerreno4 = "Pato";
                                GameManager.instance.partidaGuardada.dinero -= precioPerro;
                            }
                            else if (AnimalesEnT4 < 10 && TerrenoManager.instance.AnimalTerreno4 == "Pato")
                            {
                                AnimalesEnT4 += 1;
                                GameManager.instance.partidaGuardada.dinero -= precioPato;
                            }
                            else
                            {
                                if (AnimalesEnT5 == 0)
                                {
                                    asignarTerreno = 4;
                                    AnimalesEnT5 += 1;
                                    var contenedor = Instantiate(Comprables[2], Terrenos[asignarTerreno].transform.position, Terrenos[asignarTerreno].transform.rotation);
                                    contenedor.transform.parent = Terrenos[asignarTerreno].transform;
                                    TerrenoManager.instance.AnimalSprite5 = contenedor;
                                    TerrenoManager.instance.used5 = true;
                                    TerrenoManager.instance.AnimalTerreno5 = "Pato";
                                    GameManager.instance.partidaGuardada.dinero -= precioPato;
                                }
                                else if (AnimalesEnT5 < 10 && TerrenoManager.instance.AnimalTerreno5 == "Pato")
                                {
                                    AnimalesEnT5 += 1;
                                    GameManager.instance.partidaGuardada.dinero -= precioPato;
                                }
                                else
                                {
                                    if (AnimalesEnT6 == 0)
                                    {
                                        asignarTerreno = 5;
                                        AnimalesEnT6 += 1;
                                        var contenedor = Instantiate(Comprables[2], Terrenos[asignarTerreno].transform.position, Terrenos[asignarTerreno].transform.rotation);
                                        contenedor.transform.parent = Terrenos[asignarTerreno].transform;
                                        TerrenoManager.instance.AnimalSprite6 = contenedor;
                                        TerrenoManager.instance.used6 = true;
                                        TerrenoManager.instance.AnimalTerreno6 = "Pato";
                                        GameManager.instance.partidaGuardada.dinero -= precioPato;
                                    }
                                    else if (AnimalesEnT6 < 10 && TerrenoManager.instance.AnimalTerreno6 == "Pato")
                                    {
                                        AnimalesEnT6 += 1;
                                        GameManager.instance.partidaGuardada.dinero -= precioPato;
                                    }
                                    else
                                    {
                                        Debug.Log("No tienes espacio disponible");
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
                Debug.Log("No tienes dinero suficiente");
            }
        }
    }
    public void ComprarTigre()
    {
        if (IsFull == true && TerrenoManager.instance.TerrenoDisponible == false)
        {
            Debug.Log("No tienes espacio disponible.");
        }
        else
        {
            if (GameManager.instance.partidaGuardada.dinero >= precioTigre)
            {
                if (AnimalesEnT1 == 0)
                {
                    asignarTerreno = 0;
                    AnimalesEnT1 += 1;
                    var contenedor = Instantiate(Comprables[3], Terrenos[asignarTerreno].transform.position, Terrenos[asignarTerreno].transform.rotation);
                    contenedor.transform.parent = Terrenos[asignarTerreno].transform;
                    TerrenoManager.instance.AnimalSprite1 = contenedor;
                    TerrenoManager.instance.used1 = true;
                    TerrenoManager.instance.AnimalTerreno1 = "Tigre";
                    GameManager.instance.partidaGuardada.dinero -= precioTigre;
                }
                else if (AnimalesEnT1 < 10 && TerrenoManager.instance.AnimalTerreno1 == "Tigre")
                {
                    AnimalesEnT1 += 1;
                    GameManager.instance.partidaGuardada.dinero -= precioTigre;
                }
                else
                {
                    if (AnimalesEnT2 == 0)
                    {
                        asignarTerreno = 1;
                        AnimalesEnT2 += 1;
                        var contenedor = Instantiate(Comprables[3], Terrenos[asignarTerreno].transform.position, Terrenos[asignarTerreno].transform.rotation);
                        contenedor.transform.parent = Terrenos[asignarTerreno].transform;
                        TerrenoManager.instance.AnimalSprite2 = contenedor;
                        TerrenoManager.instance.used2 = true;
                        TerrenoManager.instance.AnimalTerreno2 = "Tigre";
                        GameManager.instance.partidaGuardada.dinero -= precioTigre;
                    }
                    else if (AnimalesEnT2 < 10 && TerrenoManager.instance.AnimalTerreno2 == "Tigre")
                    {
                        AnimalesEnT2 += 1;
                        GameManager.instance.partidaGuardada.dinero -= precioTigre;
                    }
                    else
                    {
                        if (AnimalesEnT3 == 0)
                        {
                            asignarTerreno = 2;
                            AnimalesEnT3 += 1;
                            var contenedor = Instantiate(Comprables[3], Terrenos[asignarTerreno].transform.position, Terrenos[asignarTerreno].transform.rotation);
                            contenedor.transform.parent = Terrenos[asignarTerreno].transform;
                            TerrenoManager.instance.AnimalSprite3 = contenedor;
                            TerrenoManager.instance.used3 = true;
                            TerrenoManager.instance.AnimalTerreno3 = "Tigre";
                            GameManager.instance.partidaGuardada.dinero -= precioTigre;
                        }
                        else if (AnimalesEnT3 < 10 && TerrenoManager.instance.AnimalTerreno3 == "Tigre")
                        {
                            AnimalesEnT3 += 1;
                            GameManager.instance.partidaGuardada.dinero -= precioTigre;
                        }
                        else
                        {
                            if (AnimalesEnT4 == 0)
                            {
                                asignarTerreno = 3;
                                AnimalesEnT4 += 1;
                                var contenedor = Instantiate(Comprables[3], Terrenos[asignarTerreno].transform.position, Terrenos[asignarTerreno].transform.rotation);
                                contenedor.transform.parent = Terrenos[asignarTerreno].transform;
                                TerrenoManager.instance.AnimalSprite4 = contenedor;
                                TerrenoManager.instance.used4 = true;
                                TerrenoManager.instance.AnimalTerreno4 = "Tigre";
                                GameManager.instance.partidaGuardada.dinero -= precioTigre;
                            }
                            else if (AnimalesEnT4 < 10 && TerrenoManager.instance.AnimalTerreno4 == "Tigre")
                            {
                                AnimalesEnT4 += 1;
                                GameManager.instance.partidaGuardada.dinero -= precioPato;
                            }
                            else
                            {
                                if (AnimalesEnT5 == 0)
                                {
                                    asignarTerreno = 4;
                                    AnimalesEnT5 += 1;
                                    var contenedor = Instantiate(Comprables[3], Terrenos[asignarTerreno].transform.position, Terrenos[asignarTerreno].transform.rotation);
                                    contenedor.transform.parent = Terrenos[asignarTerreno].transform;
                                    TerrenoManager.instance.AnimalSprite5 = contenedor;
                                    TerrenoManager.instance.used5 = true;
                                    TerrenoManager.instance.AnimalTerreno5 = "Tigre";
                                    GameManager.instance.partidaGuardada.dinero -= precioTigre;
                                }
                                else if (AnimalesEnT5 < 10 && TerrenoManager.instance.AnimalTerreno5 == "Tigre")
                                {
                                    AnimalesEnT5 += 1;
                                    GameManager.instance.partidaGuardada.dinero -= precioTigre;
                                }
                                else
                                {
                                    if (AnimalesEnT6 == 0)
                                    {
                                        asignarTerreno = 5;
                                        AnimalesEnT6 += 1;
                                        var contenedor = Instantiate(Comprables[3], Terrenos[asignarTerreno].transform.position, Terrenos[asignarTerreno].transform.rotation);
                                        contenedor.transform.parent = Terrenos[asignarTerreno].transform;
                                        TerrenoManager.instance.AnimalSprite6 = contenedor;
                                        TerrenoManager.instance.used6 = true;
                                        TerrenoManager.instance.AnimalTerreno6 = "Tigre";
                                        GameManager.instance.partidaGuardada.dinero -= precioTigre;
                                    }
                                    else if (AnimalesEnT6 < 10 && TerrenoManager.instance.AnimalTerreno6 == "Tigre")
                                    {
                                        AnimalesEnT6 += 1;
                                        GameManager.instance.partidaGuardada.dinero -= precioTigre;
                                    }
                                    else
                                    {
                                        Debug.Log("No tienes espacio disponible");
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
                Debug.Log("No tienes dinero suficiente");
            }
        }
    }
    public void ComprarZorro()
    {
        if (IsFull == true && TerrenoManager.instance.TerrenoDisponible == false)
        {
            Debug.Log("No tienes espacio disponible.");
        }
        else
        {
            if (GameManager.instance.partidaGuardada.dinero >= precioZorro)
            {
                if (AnimalesEnT1 == 0)
                {
                    asignarTerreno = 0;
                    AnimalesEnT1 += 1;
                    var contenedor = Instantiate(Comprables[4], Terrenos[asignarTerreno].transform.position, Terrenos[asignarTerreno].transform.rotation);
                    contenedor.transform.parent = Terrenos[asignarTerreno].transform;
                    TerrenoManager.instance.AnimalSprite1 = contenedor;
                    TerrenoManager.instance.used1 = true;
                    TerrenoManager.instance.AnimalTerreno1 = "Zorro";
                    GameManager.instance.partidaGuardada.dinero -= precioZorro;
                }
                else if (AnimalesEnT1 < 10 && TerrenoManager.instance.AnimalTerreno1 == "Zorro")
                {
                    AnimalesEnT1 += 1;
                    GameManager.instance.partidaGuardada.dinero -= precioZorro;
                }
                else
                {
                    if (AnimalesEnT2 == 0)
                    {
                        asignarTerreno = 1;
                        AnimalesEnT2 += 1;
                        var contenedor = Instantiate(Comprables[4], Terrenos[asignarTerreno].transform.position, Terrenos[asignarTerreno].transform.rotation);
                        contenedor.transform.parent = Terrenos[asignarTerreno].transform;
                        TerrenoManager.instance.AnimalSprite2 = contenedor;
                        TerrenoManager.instance.used2 = true;
                        TerrenoManager.instance.AnimalTerreno2 = "Zorro";
                        GameManager.instance.partidaGuardada.dinero -= precioZorro;
                    }
                    else if (AnimalesEnT2 < 10 && TerrenoManager.instance.AnimalTerreno2 == "Zorro")
                    {
                        AnimalesEnT2 += 1;
                        GameManager.instance.partidaGuardada.dinero -= precioZorro;
                    }
                    else
                    {
                        if (AnimalesEnT3 == 0)
                        {
                            asignarTerreno = 2;
                            AnimalesEnT3 += 1;
                            var contenedor = Instantiate(Comprables[4], Terrenos[asignarTerreno].transform.position, Terrenos[asignarTerreno].transform.rotation);
                            contenedor.transform.parent = Terrenos[asignarTerreno].transform;
                            TerrenoManager.instance.AnimalSprite3 = contenedor;
                            TerrenoManager.instance.used3 = true;
                            TerrenoManager.instance.AnimalTerreno3 = "Zorro";
                            GameManager.instance.partidaGuardada.dinero -= precioZorro;
                        }
                        else if (AnimalesEnT3 < 10 && TerrenoManager.instance.AnimalTerreno3 == "Zorro")
                        {
                            AnimalesEnT3 += 1;
                            GameManager.instance.partidaGuardada.dinero -= precioZorro;
                        }
                        else
                        {
                            if (AnimalesEnT4 == 0)
                            {
                                asignarTerreno = 3;
                                AnimalesEnT4 += 1;
                                var contenedor = Instantiate(Comprables[4], Terrenos[asignarTerreno].transform.position, Terrenos[asignarTerreno].transform.rotation);
                                contenedor.transform.parent = Terrenos[asignarTerreno].transform;
                                TerrenoManager.instance.AnimalSprite4 = contenedor;
                                TerrenoManager.instance.used4 = true;
                                TerrenoManager.instance.AnimalTerreno4 = "Zorro";
                                GameManager.instance.partidaGuardada.dinero -= precioZorro;
                            }
                            else if (AnimalesEnT4 < 10 && TerrenoManager.instance.AnimalTerreno4 == "Zorro")
                            {
                                AnimalesEnT4 += 1;
                                GameManager.instance.partidaGuardada.dinero -= precioZorro;
                            }
                            else
                            {
                                if (AnimalesEnT5 == 0)
                                {
                                    asignarTerreno = 4;
                                    AnimalesEnT5 += 1;
                                    var contenedor = Instantiate(Comprables[4], Terrenos[asignarTerreno].transform.position, Terrenos[asignarTerreno].transform.rotation);
                                    contenedor.transform.parent = Terrenos[asignarTerreno].transform;
                                    TerrenoManager.instance.AnimalSprite5 = contenedor;
                                    TerrenoManager.instance.used5 = true;
                                    TerrenoManager.instance.AnimalTerreno5 = "Zorro";
                                    GameManager.instance.partidaGuardada.dinero -= precioZorro;
                                }
                                else if (AnimalesEnT5 < 10 && TerrenoManager.instance.AnimalTerreno5 == "Zorro")
                                {
                                    AnimalesEnT5 += 1;
                                    GameManager.instance.partidaGuardada.dinero -= precioZorro;
                                }
                                else
                                {
                                    if (AnimalesEnT6 == 0)
                                    {
                                        asignarTerreno = 5;
                                        AnimalesEnT6 += 1;
                                        var contenedor = Instantiate(Comprables[4], Terrenos[asignarTerreno].transform.position, Terrenos[asignarTerreno].transform.rotation);
                                        contenedor.transform.parent = Terrenos[asignarTerreno].transform;
                                        TerrenoManager.instance.AnimalSprite6 = contenedor;
                                        TerrenoManager.instance.used6 = true;
                                        TerrenoManager.instance.AnimalTerreno6 = "Zorro";
                                        GameManager.instance.partidaGuardada.dinero -= precioZorro;
                                    }
                                    else if (AnimalesEnT6 < 10 && TerrenoManager.instance.AnimalTerreno6 == "Zorro")
                                    {
                                        AnimalesEnT6 += 1;
                                        GameManager.instance.partidaGuardada.dinero -= precioZorro;
                                    }
                                    else
                                    {
                                        Debug.Log("No tienes espacio disponible");
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
                Debug.Log("No tienes dinero suficiente");
            }
        }
    }
    public void ComprarPollo()
    {
        if (IsFull == true && TerrenoManager.instance.TerrenoDisponible == false)
        {
            Debug.Log("No tienes espacio disponible.");
        }
        else
        {
            if (GameManager.instance.partidaGuardada.dinero >= precioZorro)
            {
                if (AnimalesEnT1 == 0)
                {
                    asignarTerreno = 0;
                    AnimalesEnT1 += 1;
                    var contenedor = Instantiate(Comprables[5], Terrenos[asignarTerreno].transform.position, Terrenos[asignarTerreno].transform.rotation);
                    contenedor.transform.parent = Terrenos[asignarTerreno].transform;
                    TerrenoManager.instance.AnimalSprite1 = contenedor;
                    TerrenoManager.instance.used1 = true;
                    TerrenoManager.instance.AnimalTerreno1 = "Pollo";
                    GameManager.instance.partidaGuardada.dinero -= precioPollo;
                }
                else if (AnimalesEnT1 < 10 && TerrenoManager.instance.AnimalTerreno1 == "Pollo")
                {
                    AnimalesEnT1 += 1;
                    GameManager.instance.partidaGuardada.dinero -= precioPollo;
                }
                else
                {
                    if (AnimalesEnT2 == 0)
                    {
                        asignarTerreno = 1;
                        AnimalesEnT2 += 1;
                        var contenedor = Instantiate(Comprables[5], Terrenos[asignarTerreno].transform.position, Terrenos[asignarTerreno].transform.rotation);
                        contenedor.transform.parent = Terrenos[asignarTerreno].transform;
                        TerrenoManager.instance.AnimalSprite2 = contenedor;
                        TerrenoManager.instance.used2 = true;
                        TerrenoManager.instance.AnimalTerreno2 = "Pollo";
                        GameManager.instance.partidaGuardada.dinero -= precioPollo;
                    }
                    else if (AnimalesEnT2 < 10 && TerrenoManager.instance.AnimalTerreno2 == "Pollo")
                    {
                        AnimalesEnT2 += 1;
                        GameManager.instance.partidaGuardada.dinero -= precioPollo;
                    }
                    else
                    {
                        if (AnimalesEnT3 == 0)
                        {
                            asignarTerreno = 2;
                            AnimalesEnT3 += 1;
                            var contenedor = Instantiate(Comprables[5], Terrenos[asignarTerreno].transform.position, Terrenos[asignarTerreno].transform.rotation);
                            contenedor.transform.parent = Terrenos[asignarTerreno].transform;
                            TerrenoManager.instance.AnimalSprite3 = contenedor;
                            TerrenoManager.instance.used3 = true;
                            TerrenoManager.instance.AnimalTerreno3 = "Pollo";
                            GameManager.instance.partidaGuardada.dinero -= precioPollo;
                        }
                        else if (AnimalesEnT3 < 10 && TerrenoManager.instance.AnimalTerreno3 == "Pollo")
                        {
                            AnimalesEnT3 += 1;
                            GameManager.instance.partidaGuardada.dinero -= precioPollo;
                        }
                        else
                        {
                            if (AnimalesEnT4 == 0)
                            {
                                asignarTerreno = 3;
                                AnimalesEnT4 += 1;
                                var contenedor = Instantiate(Comprables[5], Terrenos[asignarTerreno].transform.position, Terrenos[asignarTerreno].transform.rotation);
                                contenedor.transform.parent = Terrenos[asignarTerreno].transform;
                                TerrenoManager.instance.AnimalSprite4 = contenedor;
                                TerrenoManager.instance.used4 = true;
                                TerrenoManager.instance.AnimalTerreno4 = "Pollo";
                                GameManager.instance.partidaGuardada.dinero -= precioPollo;
                            }
                            else if (AnimalesEnT4 < 10 && TerrenoManager.instance.AnimalTerreno4 == "Pollo")
                            {
                                AnimalesEnT4 += 1;
                                GameManager.instance.partidaGuardada.dinero -= precioPollo;
                            }
                            else
                            {
                                if (AnimalesEnT5 == 0)
                                {
                                    asignarTerreno = 4;
                                    AnimalesEnT5 += 1;
                                    var contenedor = Instantiate(Comprables[5], Terrenos[asignarTerreno].transform.position, Terrenos[asignarTerreno].transform.rotation);
                                    contenedor.transform.parent = Terrenos[asignarTerreno].transform;
                                    TerrenoManager.instance.AnimalSprite5 = contenedor;
                                    TerrenoManager.instance.used5 = true;
                                    TerrenoManager.instance.AnimalTerreno5 = "Pollo";
                                    GameManager.instance.partidaGuardada.dinero -= precioPollo;
                                }
                                else if (AnimalesEnT5 < 10 && TerrenoManager.instance.AnimalTerreno5 == "Pollo")
                                {
                                    AnimalesEnT5 += 1;
                                    GameManager.instance.partidaGuardada.dinero -= precioPollo;
                                }
                                else
                                {
                                    if (AnimalesEnT6 == 0)
                                    {
                                        asignarTerreno = 5;
                                        AnimalesEnT6 += 1;
                                        var contenedor = Instantiate(Comprables[5], Terrenos[asignarTerreno].transform.position, Terrenos[asignarTerreno].transform.rotation);
                                        contenedor.transform.parent = Terrenos[asignarTerreno].transform;
                                        TerrenoManager.instance.AnimalSprite6 = contenedor;
                                        TerrenoManager.instance.used6 = true;
                                        TerrenoManager.instance.AnimalTerreno6 = "Pollo";
                                        GameManager.instance.partidaGuardada.dinero -= precioPollo;
                                    }
                                    else if (AnimalesEnT6 < 10 && TerrenoManager.instance.AnimalTerreno6 == "Pollo")
                                    {
                                        AnimalesEnT6 += 1;
                                        GameManager.instance.partidaGuardada.dinero -= precioPollo;
                                    }
                                    else
                                    {
                                        Debug.Log("No tienes espacio disponible");
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
                Debug.Log("No tienes dinero suficiente");
            }
        }
    }


    public void EspacioDisponible()
    {
        if ((AnimalesEnT1 >= 10) && (AnimalesEnT2 >= 10) && (AnimalesEnT3 >= 10) && (AnimalesEnT4 >= 10) && (AnimalesEnT5 >= 10) && (AnimalesEnT6 >= 10))
        {
            IsFull = true;
        }
        else
        {
            IsFull = false;
        }
    }
    

}

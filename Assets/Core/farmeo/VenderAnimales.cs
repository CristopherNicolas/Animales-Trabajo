using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using TMPro;
using System.Threading.Tasks;
using UnityEngine.UI;

public class VenderAnimales : MonoBehaviour
{
    public bool Vendiendo;
    public List<Text> CantAnimales;
    public int Gatos, Perros, Patos, Tigres, Zorros, Pollos;
    public static VenderAnimales instance;
    public void Awake()
    {
        if (instance == null)
        {
            GetComponent<RectTransform>().DOScale(0, 0);
            instance = this;
            textoUi =GameObject.Find("feed").GetComponent<Text>();
        }
    }
    private void FixedUpdate()
    {
        CantAnimales[0].text = "" + Gatos + "Precio:" + Tienda.instance.precioGato;
        CantAnimales[1].text = "" + Perros + "Precio:" + Tienda.instance.precioPerro;
        CantAnimales[2].text = "" + Patos + "Precio:" + Tienda.instance.precioPato;
        CantAnimales[3].text = "" + Tigres + "Precio:" + Tienda.instance.precioTigre;
        CantAnimales[4].text = "" + Zorros + "Precio:" + Tienda.instance.precioZorro;
        CantAnimales[5].text = "" + Pollos + "Precio:" + Tienda.instance.precioPollo;
    }
    public void AbrirVender()
    {
        if (Vendiendo)
        {
            CerrarVender();
        }
        else
        {
            Vendiendo = true;
            GetComponent<RectTransform>().DOScale(1, 0.5f);
        }
    }
    public void CerrarVender()
    {
        GetComponent<RectTransform>().DOScale(0, 0.5f);
        Vendiendo = false;
    }

    public void VenderGatos()
    {
        if (TerrenoManager.instance.AnimalTerreno6 == "Gato" && Tienda.instance.AnimalesEnT6 > 0 && Gatos > 0)
        {
            Tienda.instance.AnimalesEnT6 -= 1;
            Gatos -= 1;
            GameManager.instance.partidaGuardada.dinero += Tienda.instance.precioGato;
        }
        else if (Gatos == 0)
        {
            MostrarMensaje("No tienes gatos para vender");
        }
        else
        {
            if (TerrenoManager.instance.AnimalTerreno5 == "Gato" && Tienda.instance.AnimalesEnT5 > 0)
            {
                Tienda.instance.AnimalesEnT5 -= 1;
                Gatos -= 1;
                GameManager.instance.partidaGuardada.dinero += Tienda.instance.precioGato;
            }
            else
            {
                if (TerrenoManager.instance.AnimalTerreno4 == "Gato" && Tienda.instance.AnimalesEnT4 > 0)
                {
                    Tienda.instance.AnimalesEnT4 -= 1;
                    Gatos -= 1;
                    GameManager.instance.partidaGuardada.dinero += Tienda.instance.precioGato;
                }
                else
                {
                    if (TerrenoManager.instance.AnimalTerreno3 == "Gato" && Tienda.instance.AnimalesEnT3 > 0)
                    {
                        Tienda.instance.AnimalesEnT3 -= 1;
                        Gatos -= 1;
                        GameManager.instance.partidaGuardada.dinero += Tienda.instance.precioGato;
                    }
                    else
                    {
                        if (TerrenoManager.instance.AnimalTerreno2 == "Gato" && Tienda.instance.AnimalesEnT2 > 0)
                        {
                            Tienda.instance.AnimalesEnT2 -= 1;
                            Gatos -= 1;
                            GameManager.instance.partidaGuardada.dinero += Tienda.instance.precioGato;
                        }
                        else
                        {
                            if (TerrenoManager.instance.AnimalTerreno1 == "Gato" && Tienda.instance.AnimalesEnT1 > 0)
                            {
                                Tienda.instance.AnimalesEnT1 -= 1;
                                Gatos -= 1;
                                GameManager.instance.partidaGuardada.dinero += Tienda.instance.precioGato;
                            }
                        }
                    }
                }
            }
        }
    }
    public void VenderPerros()
    {
        if (TerrenoManager.instance.AnimalTerreno6 == "Perro" && Tienda.instance.AnimalesEnT6 > 0 && Perros > 0)
        {
            Tienda.instance.AnimalesEnT6 -= 1;
            Perros -= 1;
            GameManager.instance.partidaGuardada.dinero += Tienda.instance.precioPerro;
        }
        else if (Perros == 0)
        {
            MostrarMensaje("No tienes perros para vender");
        }
        else
        {
            if (TerrenoManager.instance.AnimalTerreno5 == "Perro" && Tienda.instance.AnimalesEnT5 > 0)
            {
                Tienda.instance.AnimalesEnT5 -= 1;
                Perros -= 1;
                GameManager.instance.partidaGuardada.dinero += Tienda.instance.precioPerro;
            }
            else
            {
                if (TerrenoManager.instance.AnimalTerreno4 == "Perro" && Tienda.instance.AnimalesEnT4 > 0)
                {
                    Tienda.instance.AnimalesEnT4 -= 1;
                    Perros -= 1;
                    GameManager.instance.partidaGuardada.dinero += Tienda.instance.precioPerro;
                }
                else
                {
                    if (TerrenoManager.instance.AnimalTerreno3 == "Perro" && Tienda.instance.AnimalesEnT3 > 0)
                    {
                        Tienda.instance.AnimalesEnT3 -= 1;
                        Perros -= 1;
                        GameManager.instance.partidaGuardada.dinero += Tienda.instance.precioPerro;
                    }
                    else
                    {
                        if (TerrenoManager.instance.AnimalTerreno2 == "Perro" && Tienda.instance.AnimalesEnT2 > 0)
                        {
                            Tienda.instance.AnimalesEnT2 -= 1;
                            Perros -= 1;
                            GameManager.instance.partidaGuardada.dinero += Tienda.instance.precioPerro;
                        }
                        else
                        {
                            if (TerrenoManager.instance.AnimalTerreno1 == "Perro" && Tienda.instance.AnimalesEnT1 > 0)
                            {
                                Tienda.instance.AnimalesEnT1 -= 1;
                                Perros -= 1;
                                GameManager.instance.partidaGuardada.dinero += Tienda.instance.precioPerro;
                            }
                        }
                    }
                }
            }
        }
    }
    public void VenderPatos()
    {
        if (TerrenoManager.instance.AnimalTerreno6 == "Pato" && Tienda.instance.AnimalesEnT6 > 0 && Patos > 0)
        {
            Tienda.instance.AnimalesEnT6 -= 1;
            Patos -= 1;
            GameManager.instance.partidaGuardada.dinero += Tienda.instance.precioPato;
        }
        else if (Patos == 0)
        {
            MostrarMensaje("No tienes patos para vender");
        }
        else
        {
            if (TerrenoManager.instance.AnimalTerreno5 == "Pato" && Tienda.instance.AnimalesEnT5 > 0)
            {
                Tienda.instance.AnimalesEnT5 -= 1;
                Patos -= 1;
                GameManager.instance.partidaGuardada.dinero += Tienda.instance.precioPato;
            }
            else
            {
                if (TerrenoManager.instance.AnimalTerreno4 == "Pato" && Tienda.instance.AnimalesEnT4 > 0)
                {
                    Tienda.instance.AnimalesEnT4 -= 1;
                    Patos -= 1;
                    GameManager.instance.partidaGuardada.dinero += Tienda.instance.precioPato;
                }
                else
                {
                    if (TerrenoManager.instance.AnimalTerreno3 == "Pato" && Tienda.instance.AnimalesEnT3 > 0)
                    {
                        Tienda.instance.AnimalesEnT3 -= 1;
                        Patos -= 1;
                        GameManager.instance.partidaGuardada.dinero += Tienda.instance.precioPato;
                    }
                    else
                    {
                        if (TerrenoManager.instance.AnimalTerreno2 == "Pato" && Tienda.instance.AnimalesEnT2 > 0)
                        {
                            Tienda.instance.AnimalesEnT2 -= 1;
                            Patos -= 1;
                            GameManager.instance.partidaGuardada.dinero += Tienda.instance.precioPato;
                        }
                        else
                        {
                            if (TerrenoManager.instance.AnimalTerreno1 == "Pato" && Tienda.instance.AnimalesEnT1 > 0)
                            {
                                Tienda.instance.AnimalesEnT1 -= 1;
                                Patos -= 1;
                                GameManager.instance.partidaGuardada.dinero += Tienda.instance.precioPato;
                            }
                        }
                    }
                }
            }
        }
    }
    public void VenderTigres()
    {
        if (TerrenoManager.instance.AnimalTerreno6 == "Tigre" && Tienda.instance.AnimalesEnT6 > 0 && Tigres > 0)
        {
            Tienda.instance.AnimalesEnT6 -= 1;
            Tigres -= 1;
            GameManager.instance.partidaGuardada.dinero += Tienda.instance.precioTigre;
        }
        else if (Tigres == 0)
        {
            MostrarMensaje("No tienes tigres para vender");
        }
        else
        {
            if (TerrenoManager.instance.AnimalTerreno5 == "Tigre" && Tienda.instance.AnimalesEnT5 > 0)
            {
                Tienda.instance.AnimalesEnT5 -= 1;
                Tigres -= 1;
                GameManager.instance.partidaGuardada.dinero += Tienda.instance.precioTigre;
            }
            else
            {
                if (TerrenoManager.instance.AnimalTerreno4 == "Tigre" && Tienda.instance.AnimalesEnT4 > 0)
                {
                    Tienda.instance.AnimalesEnT4 -= 1;
                    Tigres -= 1;
                    GameManager.instance.partidaGuardada.dinero += Tienda.instance.precioTigre;
                }
                else
                {
                    if (TerrenoManager.instance.AnimalTerreno3 == "Tigre" && Tienda.instance.AnimalesEnT3 > 0)
                    {
                        Tienda.instance.AnimalesEnT3 -= 1;
                        Tigres -= 1;
                        GameManager.instance.partidaGuardada.dinero += Tienda.instance.precioTigre;
                    }
                    else
                    {
                        if (TerrenoManager.instance.AnimalTerreno2 == "Tigre" && Tienda.instance.AnimalesEnT2 > 0)
                        {
                            Tienda.instance.AnimalesEnT2 -= 1;
                            Tigres -= 1;
                            GameManager.instance.partidaGuardada.dinero += Tienda.instance.precioTigre;
                        }
                        else
                        {
                            if (TerrenoManager.instance.AnimalTerreno1 == "Tigre" && Tienda.instance.AnimalesEnT1 > 0)
                            {
                                Tienda.instance.AnimalesEnT1 -= 1;
                                Tigres -= 1;
                                GameManager.instance.partidaGuardada.dinero += Tienda.instance.precioTigre;
                            }
                        }
                    }
                }
            }
        }
    }
    [SerializeField]Text textoUi;
    public async void MostrarMensaje(string mensaje)
    {
        textoUi.text = mensaje;
        await Task.Delay(1000);
        await Task.Delay(1000);
        textoUi.text = "";
    }
    public void VenderZorros()
    {
        if (TerrenoManager.instance.AnimalTerreno6 == "Zorro" && Tienda.instance.AnimalesEnT6 > 0 && Zorros > 0)
        {
            Tienda.instance.AnimalesEnT6 -= 1;
            Zorros -= 1;
            GameManager.instance.partidaGuardada.dinero += Tienda.instance.precioZorro;
        }
        else if (Zorros == 0)
        {
           MostrarMensaje("No tienes zorros para vender");
        }
        else
        {
            if (TerrenoManager.instance.AnimalTerreno5 == "Zorro" && Tienda.instance.AnimalesEnT5 > 0)
            {
                Tienda.instance.AnimalesEnT5 -= 1;
                Zorros -= 1;
                GameManager.instance.partidaGuardada.dinero += Tienda.instance.precioZorro;
            }
            else
            {
                if (TerrenoManager.instance.AnimalTerreno4 == "Zorro" && Tienda.instance.AnimalesEnT4 > 0)
                {
                    Tienda.instance.AnimalesEnT4 -= 1;
                    Zorros -= 1;
                    GameManager.instance.partidaGuardada.dinero += Tienda.instance.precioZorro;
                }
                else
                {
                    if (TerrenoManager.instance.AnimalTerreno3 == "Zorro" && Tienda.instance.AnimalesEnT3 > 0)
                    {
                        Tienda.instance.AnimalesEnT3 -= 1;
                        Zorros -= 1;
                        GameManager.instance.partidaGuardada.dinero += Tienda.instance.precioZorro;
                    }
                    else
                    {
                        if (TerrenoManager.instance.AnimalTerreno2 == "Zorro" && Tienda.instance.AnimalesEnT2 > 0)
                        {
                            Tienda.instance.AnimalesEnT2 -= 1;
                            Zorros -= 1;
                            GameManager.instance.partidaGuardada.dinero += Tienda.instance.precioZorro;
                        }
                        else
                        {
                            if (TerrenoManager.instance.AnimalTerreno1 == "Zorro" && Tienda.instance.AnimalesEnT1 > 0)
                            {
                                Tienda.instance.AnimalesEnT1 -= 1;
                                Zorros -= 1;
                                GameManager.instance.partidaGuardada.dinero += Tienda.instance.precioZorro;
                            }
                        }
                    }
                }
            }
        }
    }
    public void VenderPollos()
    {
        if (TerrenoManager.instance.AnimalTerreno6 == "Pollo" && Tienda.instance.AnimalesEnT6 > 0 && Pollos > 0)
        {
            Tienda.instance.AnimalesEnT6 -= 1;
            Pollos -= 1;
            GameManager.instance.partidaGuardada.dinero += Tienda.instance.precioPollo;
        }
        else if (Pollos == 0)
        {
            MostrarMensaje("No tienes pollos para vender");
        }
        else
        {
            if (TerrenoManager.instance.AnimalTerreno5 == "Pollo" && Tienda.instance.AnimalesEnT5 > 0)
            {
                Tienda.instance.AnimalesEnT5 -= 1;
                Pollos -= 1;
                GameManager.instance.partidaGuardada.dinero += Tienda.instance.precioPollo;
            }
            else
            {
                if (TerrenoManager.instance.AnimalTerreno4 == "Pollo" && Tienda.instance.AnimalesEnT4 > 0)
                {
                    Tienda.instance.AnimalesEnT4 -= 1;
                    Pollos -= 1;
                    GameManager.instance.partidaGuardada.dinero += Tienda.instance.precioPollo;
                }
                else
                {
                    if (TerrenoManager.instance.AnimalTerreno3 == "Pollo" && Tienda.instance.AnimalesEnT3 > 0)
                    {
                        Tienda.instance.AnimalesEnT3 -= 1;
                        Pollos -= 1;
                        GameManager.instance.partidaGuardada.dinero += Tienda.instance.precioPollo;
                    }
                    else
                    {
                        if (TerrenoManager.instance.AnimalTerreno2 == "Pollo" && Tienda.instance.AnimalesEnT2 > 0)
                        {
                            Tienda.instance.AnimalesEnT2 -= 1;
                            Pollos -= 1;
                            GameManager.instance.partidaGuardada.dinero += Tienda.instance.precioTigre;
                        }
                        else
                        {
                            if (TerrenoManager.instance.AnimalTerreno1 == "Pollo" && Tienda.instance.AnimalesEnT1 > 0)
                            {
                                Tienda.instance.AnimalesEnT1 -= 1;
                                Pollos -= 1;
                                GameManager.instance.partidaGuardada.dinero += Tienda.instance.precioPollo;
                            }
                        }
                    }
                }
            }
        }
    }
}

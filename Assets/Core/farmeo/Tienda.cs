using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class Tienda : MonoBehaviour
{
    bool IsOpen;
    public TerrenoManager ter;
    public List<GameObject> Comprables;
    public List<GameObject> Terrenos;
    public int asignarTerreno, Gatos;
    public static Tienda instance;
    public Text Gato;
    public void Awake()
    {
        if  (instance == null)
        {
            instance = this;
            GetComponent<RectTransform>().DOScale(0, 0);
            ter = GetComponent<TerrenoManager>();
        }
    }

    private void FixedUpdate()
    {
        Gato.text = "" + Gatos;
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
        Gatos += 1;
        GameObject.FindGameObjectsWithTag("ContadorGatos");
        if (GameObject.FindGameObjectsWithTag("ContadorGatos") == null)
        {
            switch (ter.used1, ter.used2, ter.used3, ter.used4, ter.used5, ter.used6)
            {
                case (false, (false || true), (false || true), (false || true), (false || true), (false || true)):
                    asignarTerreno = 0;
                    GenerarGato();
                    ter.used1 = true;
                    break;
                case (true, false, (false || true), (false || true), (false || true), (false || true)):
                    asignarTerreno = 1;
                    GenerarGato();
                    ter.used2 = true;
                    break;
                case (true, true, false, (false || true), (false || true), (false || true)):
                    asignarTerreno = 2;
                    GenerarGato();
                    ter.used3 = true;
                    break;
                case (true, true, true, false, (false || true), (false || true)):
                    asignarTerreno = 3;
                    GenerarGato();
                    ter.used4 = true;
                    break;
                case (true, true, true, true, false, (false || true)):
                    asignarTerreno = 4;
                    GenerarGato();
                    ter.used5 = true;
                    break;
                case (true, true, true, true, true, false):
                    asignarTerreno = 5;
                    GenerarGato();
                    ter.used6 = true;
                    break;
                default:
                    Debug.Log("Crack Report");
                    break;
            }
        }

    }
    public void GenerarGato()
    {
        var contenedor = Instantiate(Comprables[1], Terrenos[asignarTerreno].transform.position, Terrenos[asignarTerreno].transform.rotation);
        contenedor.transform.parent = Terrenos[asignarTerreno].transform;
        var generarTexto = Instantiate(Gato, Terrenos[asignarTerreno].transform.position, Terrenos[asignarTerreno].transform.rotation);
        generarTexto.transform.parent = Terrenos[asignarTerreno].transform;
        generarTexto.transform.localPosition = new Vector3(0f, -38.5f, 0f);
        generarTexto.text = "" + Gatos;
        Gato = generarTexto;
    }
}

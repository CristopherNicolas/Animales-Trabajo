using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GanarOro : MonoBehaviour
{
    public Text Oro;
    int PopGato, PopPerro, PopPato, PopTigre, PopZorro, PopPollo;
    public static GanarOro instance;
    public void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }

    }
    private void Start()
    {
        Oro = GetComponent<Text>();
        StartCoroutine(VariarPrecios());
        Tienda.instance.precioGato = 20f;
        Tienda.instance.precioPerro = 32f;
        Tienda.instance.precioPato = 28f;
        Tienda.instance.precioTigre = 40f;
        Tienda.instance.precioZorro = 36f;
        Tienda.instance.precioPollo = 24f;
    }

    public void FixedUpdate()
    {
        Oro.text = " $ " + GameManager.instance.partidaGuardada.dinero;
    }

    IEnumerator VariarPrecios()
    {
        yield return new WaitForSeconds(5f);
        PopGato = Random.Range(0, 2);
        PopPerro = Random.Range(0, 2);
        PopPato = Random.Range(0, 2);
        PopTigre = Random.Range(0, 2);
        PopZorro = Random.Range(0, 2);
        PopPollo = Random.Range(0, 2);
        CambiarValorGato();
        CambiarValorPerro();
        CambiarValorPato();
        CambiarValorTigre();
        CambiarValorZorro();
        CambiarValorPollo();
        StartCoroutine(VariarPrecios());
    }

    public void CambiarValorGato()
    {
        if (PopGato == 1 && Tienda.instance.precioGato <= 28f)
        {
            Tienda.instance.precioGato += 4f;
        }
        else if (PopGato == 0 && Tienda.instance.precioGato >= 12f)
        {
            Tienda.instance.precioGato -= 4f;
        }
    }
    public void CambiarValorPerro()
    {
        if (PopPerro == 1 && Tienda.instance.precioPerro <= 40f)
        {
            Tienda.instance.precioPerro += 4f;
        }
        else if (PopPerro == 0 && Tienda.instance.precioPerro >= 24f)
        {
            Tienda.instance.precioPerro -= 4f;
        }
    }
    public void CambiarValorPato()
    {
        if (PopPato == 1 && Tienda.instance.precioPato <= 36f)
        {
            Tienda.instance.precioPato += 4f;
        }
        else if (PopPato == 0 && Tienda.instance.precioPato >= 20f)
        {
            Tienda.instance.precioPato -= 4f;
        }
    }
    public void CambiarValorTigre()
    {
        if (PopTigre == 1 && Tienda.instance.precioTigre <= 48f)
        {
            Tienda.instance.precioTigre += 4f;
        }
        else if (PopTigre == 0 && Tienda.instance.precioTigre >= 32f)
        {
            Tienda.instance.precioTigre -= 4f;
        }
    }
    public void CambiarValorZorro()
    {
        if (PopZorro == 1 && Tienda.instance.precioZorro <= 44f)
        {
            Tienda.instance.precioZorro += 4f;
        }
        else if (PopZorro == 0 && Tienda.instance.precioZorro >= 28f)
        {
            Tienda.instance.precioZorro -= 4f;
        }
    }
    public void CambiarValorPollo()
    {
        if (PopPollo == 1 && Tienda.instance.precioPollo <= 32f)
        {
            Tienda.instance.precioPollo += 4f;
        }
        else if (PopPollo == 0 && Tienda.instance.precioPollo >= 16f)
        {
            Tienda.instance.precioPollo -= 4f;
        }
    }
}

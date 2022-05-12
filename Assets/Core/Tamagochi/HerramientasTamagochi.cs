using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using System.Threading.Tasks;
public delegate void Inter();

public class HerramientasTamagochi : MonoBehaviour
{
    public Inter inter;
   public Texture2D cursorAgua, cursorAlimento, cursorPeineta,cursorDefault;
    public ESTADOCURSOR eSTADOCURSOR = ESTADOCURSOR.DEFAUL;
    private void Awake()
    {
        inter = new Inter(DefaultEfect);
        AsignarCursor(eSTADOCURSOR);
        slider.transform.DOScale(0, 0);
    }
    public void Interactuar()
    {
        inter();
    }
    public void AsignarCursor(ESTADOCURSOR eSTADOCURSOR)
    {
        switch (eSTADOCURSOR)
        {
            case ESTADOCURSOR.DEFAUL: Cursor.SetCursor(cursorDefault, Vector2.zero,CursorMode.Auto);
                break;
            case ESTADOCURSOR.PEINETA:Cursor.SetCursor(cursorPeineta, Vector2.zero, CursorMode.Auto);
                break;
            case ESTADOCURSOR.AGUA:Cursor.SetCursor(cursorAgua, Vector2.zero, CursorMode.Auto);
                break;
            case ESTADOCURSOR.ALIMENTO:Cursor.SetCursor(cursorAlimento, Vector2.zero, CursorMode.Auto);
                break;
            default:
                Cursor.SetCursor(cursorDefault, Vector2.zero, CursorMode.Auto);
                break;
        }
    }
    //estos metodos se llaman con los botones del panel del ui
    public void Alimento()
    {
        if (eSTADOCURSOR == ESTADOCURSOR.ALIMENTO)
        {
            eSTADOCURSOR = ESTADOCURSOR.DEFAUL; 
             inter = new Inter(DefaultEfect);
        }
        else
        { 
        eSTADOCURSOR = ESTADOCURSOR.ALIMENTO;
        inter = new Inter(alimentoEfect);
        }
        AsignarCursor(eSTADOCURSOR);
    }
    public void Agua()
    {
        if (eSTADOCURSOR == ESTADOCURSOR.AGUA)
        {
            eSTADOCURSOR = ESTADOCURSOR.DEFAUL;
           inter = new Inter(DefaultEfect);
            
        }
        else
        {
            eSTADOCURSOR = ESTADOCURSOR.AGUA;
            inter = new Inter(AguaEfect);
        }
        AsignarCursor(eSTADOCURSOR);

    }
    public void Peineta()   
    {
        // al hacer click activa el modo peineta para peinar al animal.
        if (eSTADOCURSOR == ESTADOCURSOR.PEINETA)
        {
            eSTADOCURSOR = ESTADOCURSOR.DEFAUL;
            inter = new Inter(DefaultEfect);
        }
        else
        {
            eSTADOCURSOR = ESTADOCURSOR.PEINETA;
             inter = new Inter(PeinetaEfect);

        }
        AsignarCursor(eSTADOCURSOR);
    }
    public void DefaultEfect()
    {
        UiSystem.instance.EnviarMensaje("sonidos animal ", 0.4f,1,2);
            
    }
    public void AguaEfect()
    {
        UiSystem.instance.EnviarMensaje("Has dado agua", 0.4f,1,2);
    }
    public GameObject galletaPrefab,spawnerOBJ; 
    public async void alimentoEfect()
    {
        int range= Random.Range(0,5);
        float multiplicador,escala;
        UiSystem.instance.EnviarMensaje("clickea el alimento", 0.4f,1,2);
            await Task.Delay(System.TimeSpan.FromSeconds(1));
        for (int i = 0; i < range; i++)
        {
            multiplicador = Random.Range(0.1f, 0.5f);
            await Task.Delay(System.TimeSpan.FromSeconds(1));
             var obj = Instantiate(galletaPrefab, spawnerOBJ.GetComponent<RectTransform>());
               RectTransform objRectT = obj.GetComponent<RectTransform>();
                objRectT.DOScale(Random.Range(0.2f, 1f),0);
                 escala = objRectT.localScale.x;
                  objRectT.DOMoveX(Random.Range(-750, 1290), 0);
            objRectT.DOMoveY(-500,10*objRectT.localScale.x);
        }
    }
    public Slider slider;
    public GameObject pulgaPrefab;
    public void PeinetaEfect()
    {
        //hacer que salten pulgas para que puedan serclickeadas 
        int random = Random.Range(0, 5);
        Vector2 randomPos= new Vector2(Random.Range(231,1346),Random.Range(-370,430));
        if (random>0)
        {
           var obj= Instantiate(pulgaPrefab,randomPos,Quaternion.identity);
            obj.transform.parent = GameObject.Find("Canvas").transform;
        }
        UiSystem.instance.EnviarMensaje("Usaste la peineta",0.4f,1,2);
        slider.transform.GetComponent<RectTransform>().DOScale(5, 0.3f);
        slider.value += 20;
        if (slider.value >= 100)
        {
            UiSystem.instance.EnviarMensaje("animal peinado", 0.4f, 1, 2);
            slider.value = 0;
            slider.transform.DOScale(0, 0.5f);
        }
    }
}


public enum ESTADOCURSOR
{
   DEFAUL,PEINETA,AGUA,ALIMENTO
}

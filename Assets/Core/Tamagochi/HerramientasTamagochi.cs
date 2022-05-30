using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
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
        UiSystem.instance.CerrarPanel(8);
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
    int i = 0;
    public AudioSource animal;
    public List<AudioClip> clipsAnimal;
    public void DefaultEfect()
    {
        do
        {
            i = Random.Range(0, clipsAnimal.Count);
            animal.clip = clipsAnimal[i];
        }
        while (clipsAnimal[i]== animal.clip);
        animal.Play();
        i = 0;
    }
    public GameObject gotaAguaPrefab;
    public void AguaEfect()
    {
        UiSystem.instance.EnviarMensaje("clickea las gotas", 1,2);
        //caundo el jugador haga click en el animal apareceran 3 gotas
        int range = Random.Range(4, 7),t=4;
        Vector2 posicionParaSpawn(Vector2 ant)
        {
            int r = Random.Range(-1, 1);
            if (r < 0)
                return new Vector2(ant.x - 200, ant.y + 50);
            else return new Vector2(ant.x + 200, ant.y);
        }
        for (int i = 0; i < range; i++)
        {
            GameObject obj = Instantiate(gotaAguaPrefab,posicionParaSpawn
                (new Vector2(Random.Range(0,1000),Random.Range(-500,500))),Quaternion.identity);
            obj.transform.SetParent(GameObject.Find("Canvas").transform);
                    RectTransform rt = obj.GetComponent<RectTransform>();
            rt.DOScale(0, t);
            obj.GetComponent<Image>().DOColor(new Color(0, 0, 0, 0),t);
        }
          //cada gota tiene un numero, mientras mas alto el numero mas rapido desaparece
    }
    public GameObject galletaPrefab,spawnerOBJ; 
    public async void alimentoEfect()
    {
        int range= Random.Range(2,7);
        float multiplicador,escala;
        UiSystem.instance.EnviarMensaje("clickea el alimento", 0f,3);
            await Task.Delay(System.TimeSpan.FromSeconds(0.5f));
        for (int i = 0; i < range; i++)
        {
            multiplicador = Random.Range(0.1f, 0.5f);
            await Task.Delay(System.TimeSpan.FromSeconds(1));
             var obj = Instantiate(galletaPrefab, spawnerOBJ.GetComponent<RectTransform>());
               RectTransform objRectT = obj.GetComponent<RectTransform>();
            objRectT.SetParent(GameObject.Find("Canvas").transform);
                objRectT.DOScale(Random.Range(0.2f, 1f),0);
                 escala = objRectT.localScale.x;
                  objRectT.DOMoveX(Random.Range(0, 1000), 0);
            objRectT.DOMoveY(-500,10*objRectT.localScale.x*2);
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
        UiSystem.instance.EnviarMensaje("Usaste la peineta, elimina las pulgas",0.4f,2);
        slider.transform.GetComponent<RectTransform>().DOScale(5, 0.3f);
        slider.value += 10;
        if (slider.value >= 100)
        {
            UiSystem.instance.EnviarMensaje("animal peinado", 0.4f, 2);
            slider.value = 0;
            UiSystem.instance.diversion += 20;
            UiSystem.instance.UpdateUI();
            slider.transform.DOScale(0, 0.5f);
        }
    }
}


public enum ESTADOCURSOR
{
   DEFAUL,PEINETA,AGUA,ALIMENTO
}

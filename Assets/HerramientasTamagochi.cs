using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public delegate void Inter();

public class HerramientasTamagochi : MonoBehaviour
{
    public Inter inter;
   public Texture2D cursorAgua, cursorAlimento, cursorPeineta,cursorDefault;
    public ESTADOCURSOR eSTADOCURSOR = ESTADOCURSOR.DEFAUL;
    public void Interactuar()
    {
        inter();
    }
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
    private void Awake()
    {
        inter = new Inter(DefaultEfect);
        AsignarCursor(eSTADOCURSOR);
        
    }
    public void DefaultEfect()
    {
        Debug.Log("defalut efect");
    }
    public void AguaEfect()
    {
        Debug.Log("Agua efect");
    }
    public void alimentoEfect()
    {
        Debug.Log("alimento  efect");
    }
    public void PeinetaEfect()
    {
        Debug.Log("Peineta efect");
    }
}

public enum ESTADOCURSOR
{
   DEFAUL,PEINETA,AGUA,ALIMENTO
}

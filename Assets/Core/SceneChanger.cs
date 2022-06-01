using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{    
    public void IrAEscena (int escenaIndex)
    {
        if  (escenaIndex==1 && SceneManager.GetActiveScene().buildIndex==2)
        {
            //for (int i=0;i<Terreno.instance.)
          //  GameManager.instance.partidaGuardada.animalesEnTerrenos=
            
        }
     SceneManager.LoadScene(escenaIndex);

    }
}

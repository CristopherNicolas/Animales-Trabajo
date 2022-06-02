using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{    
  AutoSave autoSave;
    public void IrAEscena (int escenaIndex)
    {
        if  (escenaIndex==1 && SceneManager.GetActiveScene().buildIndex==2)
        {
              autoSave=GameObject.Find("AutoSave").GetComponent<AutoSave>();
               autoSave.SaveAnimals();
                AudioManager.instance.audioSource.PlayOneShot(AudioManager.instance.irEscena1);
                SceneManager.LoadScene(escenaIndex);
                return;
        }
     SceneManager.LoadScene(escenaIndex);
      AudioManager.instance.audioSource.PlayOneShot(AudioManager.instance.irEscena2);
    }
}

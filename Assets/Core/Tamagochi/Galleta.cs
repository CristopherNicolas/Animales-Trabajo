using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using System.Threading.Tasks;
public class Galleta : MonoBehaviour
{
    bool isDead=false;
   public UIParticleSystem iParticleSystem;
    private IEnumerator Start()
    {
        yield return new WaitForSecondsRealtime(5);
          Destroy(gameObject);
    }
    public void Clickear()
    {
        UiSystem.instance.hambre += 2 * transform.localScale.x;
         AudioManager.instance.PonerOneShotGalleta();
        GetComponent<Image>().sprite = null;
           iParticleSystem.Play();
        Destroy(gameObject); 
    }

}

using System;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using TMPro;
public class UiSystem : MonoBehaviour
{
    public TMP_Text feed,stats;
    bool puedeEnviarAlFeed=true;
    public float diversion, hambre;
    public static UiSystem instance;
    private void Awake()
    {
        if (instance==null)
        {
            instance = this;
        }
    }
    public async void EnviarMensaje(string msj, float delay = 1, float animationTime = 1,float stayTime=3)
    {
        if (puedeEnviarAlFeed)
        {
            puedeEnviarAlFeed = false;
            await Task.Delay(TimeSpan.FromSeconds(delay));
            feed.text = msj;
            feed.GetComponent<RectTransform>().DOMoveX(1000, animationTime);
            await Task.Delay(TimeSpan.FromSeconds(stayTime));
            feed.GetComponent<RectTransform>().DOMoveX(-1000, animationTime);
            puedeEnviarAlFeed = true;
        }         
    }
    public void UpdateUI()
    {
        stats.text = $"diversion:{diversion} hambre: {hambre}";        
    }
    
    public void Alimentar()
    {
        //alimentar segun el animal en escena
         float alimentoADescontar=
            GameObject.Find("Tamagochi System").GetComponent<TamagochiSystem>().personaje.tipoDeAnimal.ObtenerAlimento();
    }
         
}

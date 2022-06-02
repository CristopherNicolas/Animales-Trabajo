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
    public float diversion, hambre,sed;
    public static UiSystem instance;
    RectTransform panelHerramientas;
    private void Awake()
    {
        if (instance==null)
        {
            instance = this;
            panelHerramientas = GameObject.Find("panel interaccion").GetComponent<RectTransform>();
        } //singleton
    }

    private void Start()
    {
        DescontarEstadisticas();
    }
    public async void EnviarMensaje(string msj, float delay = 1,float stayTime=3)
    {
        if (puedeEnviarAlFeed)
        {
            puedeEnviarAlFeed = false;
            await Task.Delay(TimeSpan.FromSeconds(delay));
            feed.text = msj;
            await Task.Delay(TimeSpan.FromSeconds(stayTime));
            puedeEnviarAlFeed = true;
        }         
    }
    public void UpdateUI()
    {
        if(diversion<0) diversion=0; if(hambre<0) hambre=0; if(sed<0) sed=0;
        stats.text = @$"diversion:{diversion}    hambre: {(int)hambre}      sed: {sed}";
        stats.GetComponent<RectTransform>().DOPunchScale(new Vector3(0.25f, 0.25f, 0.25f),1);
        GameManager.instance.partidaGuardada.diversion= diversion;
        GameManager.instance.partidaGuardada.hambre = hambre;
        GameManager.instance.partidaGuardada.sed = sed;
    }
    public void Alimentar()
    {
        //alimentar segun el animal en escena
         float alimentoADescontar=
            GameObject.Find("Tamagochi System").GetComponent<TamagochiSystem>().personaje.tipoDeAnimal.ObtenerAlimento();
    }
    public void DarAgua(float toAdd)
    {
        sed += toAdd;
    }
    public async void CerrarPanel(float tiempoFuera)
    {
        panelHerramientas.DOMoveX(-500, 1);
        await Task.Delay(System.TimeSpan.FromSeconds(tiempoFuera));
        panelHerramientas.DOMoveX(300, 1);
    }
    public void CerrarPanel() => panelHerramientas.DOMoveX(3, 1);
    public void AbrirPanel() => panelHerramientas.DOMoveX(1, 1);
    public  async void DescontarEstadisticas()
    {
        while (true)
        {
          await Task.Delay(System.TimeSpan.FromSeconds(12));
            hambre -= 2;
            sed -= 3;
            diversion -= 1;
            UpdateUI();
        }
          
    }
         
}

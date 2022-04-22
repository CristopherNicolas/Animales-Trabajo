using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
public class TimeSystem : MonoBehaviour
{
    public Del dele;
    int minutos, horas;
    Text _minutos,_horas;
    public delegate void Del();
    public static TimeSystem instance;
    private void Awake()
    {
        if (instance==null)
        {
            instance = this;
             DontDestroyOnLoad(gameObject);
              dele = new Del(AsignTexts);
            dele += AsignVar;
            StartCoroutine(TimeLoop());
        }
    }//singleton
    public IEnumerator TimeLoop()
    {        
        while (true)
        {
          yield return new WaitForSecondsRealtime(1);
            Debug.Log($"{horas}:{minutos}");
            dele();    
        }
    }
    public void AsignTexts()
    {
        try
        {
            _horas.text = horas.ToString(); _minutos.text = minutos.ToString(); ;   
        }
        catch (NullReferenceException r)
        {
            r.ToString();
            return;
            throw;
        }
    }
    public void AsignVar()
    {
        minutos = DateTime.Now.Minute;
         horas = DateTime.Now.Hour;
    }
}

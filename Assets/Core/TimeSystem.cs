using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;
    public delegate void Del();
public class TimeSystem : MonoBehaviour
{
    public Del dele;
    TMP_Text textTime;
    int minutos, horas;
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
            textTime = GameObject.Find("TimeControllerText").GetComponent<TMP_Text>();
            textTime.text = $"{horas}:{minutos}";
        }
        catch (NullReferenceException r)
        {
           Debug.Log( r.ToString());
            
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

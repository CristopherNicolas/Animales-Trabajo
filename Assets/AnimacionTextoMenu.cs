using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;
using DG.Tweening;
using System;
public class AnimacionTextoMenu : MonoBehaviour
{
    // Start is called before the first frame update
    async void Start()
    {
        
        await Task.Delay(System.TimeSpan.FromSeconds(0.2f));
        RectTransform rectTransform = GetComponent<RectTransform>();
        rectTransform.DOMoveX(rectTransform.position.x-1800, 1.8f);
        rectTransform.DORotate(new Vector3(0,0, rectTransform.position.z - 10), 1.8f);
        await Task.Delay(System.TimeSpan.FromSeconds(1.8f));
        rectTransform.DORotate(new Vector3(0,0, rectTransform.position.z  ), 0.4f);
    }

  
}

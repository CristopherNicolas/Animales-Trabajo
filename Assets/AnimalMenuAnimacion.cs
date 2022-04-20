using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;
using DG.Tweening;
public class AnimalMenuAnimacion : MonoBehaviour
{
    public int time=1;
    // Start is called before the first frame update
     async void Start()
    {
        RectTransform rectTransform = GetComponent<RectTransform>();
        rectTransform.DOMoveY(rectTransform.position.y + 400, time);
        await Task.Delay(System.TimeSpan.FromSeconds(time));
        rectTransform.DOPunchScale(new Vector3(0.1f, 0.1f, 0.1f), 1.2f);
    }

   
}

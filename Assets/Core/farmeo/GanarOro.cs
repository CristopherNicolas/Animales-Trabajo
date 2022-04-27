using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GanarOro : MonoBehaviour
{
    public Text Oro;
    private void Start()
    {
        Oro = GetComponent<Text>();
        StartCoroutine(GanarOr());
    }
    private void Update()
    {
        
    }
    public void FixedUpdate()
    {
        Oro.text = "$" + GameManager.instance.dinero;
    }
    IEnumerator GanarOr()
    {
        yield return new WaitForSeconds(1f);
        GameManager.instance.dinero += 1;
        StartCoroutine(GanarOr());
    }
    
}

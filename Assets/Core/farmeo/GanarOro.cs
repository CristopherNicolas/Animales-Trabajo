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
    }
    private void Update()
    {
        
    }
    public void FixedUpdate()
    {
        Oro.text = " $ " + GameManager.instance.partidaGuardada.dinero;
    }

    
}

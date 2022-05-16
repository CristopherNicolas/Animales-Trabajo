using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pruebas : MonoBehaviour
{
    public GameObject obj1,obj2;
    public void LoQueSea()
    {
        var contenedor = Instantiate(obj2, obj1.transform.position, obj1.transform.rotation);
        contenedor.transform.parent = obj1.transform;
        return;
    }
}

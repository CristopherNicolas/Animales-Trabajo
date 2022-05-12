using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Galleta : MonoBehaviour
{
    private IEnumerator Start()
    {
        yield return new WaitForSecondsRealtime(5);
          Destroy(gameObject);
    }
    public void Clickear()
    {
        Destroy(gameObject);
          
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 public class Dog : Animal
{
    private void Start()
    {
        colorParaBgSystem = Color.red;
    }
    public override float ObtenerOro()
    {
        return 5;
    }
}

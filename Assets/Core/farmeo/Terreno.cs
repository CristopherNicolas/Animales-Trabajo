using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Terreno : MonoBehaviour
{
    // Start is called before the first frame update
    public List<Animal> terrenos;
    void Start()
    {
        terrenos.Add(new Cat());
        terrenos.Add(new Dog());
        terrenos[0].ObtenerOro();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

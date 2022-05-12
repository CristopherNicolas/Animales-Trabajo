using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrenoManager : MonoBehaviour
{
    public List<Terreno> terrenos;
    public List<Animal> animales;

    private void Awake()
    {
        terrenos[0].animals.Add(animales[1]);
    }
    private void Update()
    {
        
    }

    public void CompraAnimal(Animal animal)
    {
        foreach(Terreno ter in terrenos)
        {
            if (!ter.Used)
            {
                ter.Used = true;
                ter.animals.Add(animal);
                print("Animal agregado");
                return;
            }

            else
            {
                ter.animals.Add(animal);
            }
        }
        print("No encontro terreno.");
    }

    
}

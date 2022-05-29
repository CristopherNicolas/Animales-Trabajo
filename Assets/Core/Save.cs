using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class Save 
{
    public List<string> animalEnTerreno; //Nominados en la script TerrenoManager: public string AnimalTerreno1, AnimalTerreno2,AnimalTerreno3,AnimalTerreno4,AnimalTerreno5;animalTerreno6.
    //opciones a usar: "Gato" "Perro" "Pato" "Tigre" "Zorro" "Pollo".

    public List<GameObject> spritesEnTerrenos; //Nominados en la script TerrenoManager: public GameObject AnimalSprite1, AnimalSprite2,AnimalSprite3,AnimalSprite4,AnimalSprite5;animalSprite6.
    public List<int> animalesPorTerreno; //Nominados en la script Tienda: public int AnimalesEnT1, AnimalesEnT2,AnimalesEn3,AnimalesEnT4,AnimalesEnT5;AnimalesEnT6.
    public List<float> gananciasPorTerreno;//Nominados en la script Terreno: GananciasT1,GananciasT2,GananciasT3,GananciasT4,GananciasT5,GananciasT6.
    public List<Animal> animalesEnTerrenos;
    public float dinero;
}

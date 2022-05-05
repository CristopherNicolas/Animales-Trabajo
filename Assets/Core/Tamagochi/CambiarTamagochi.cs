using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambiarTamagochi : MonoBehaviour
{
    public int terrenoActual = 0;
    public TamagochiSystem tamagochiSystem;
    // cambiar tamagochi al presionar los botones
    public void CambiarAnimal()
    {
     // guardar stats
        if (terrenoActual < GameManager.instance.partidaGuardada.animalesEnTerrenos.Count)
        {
            terrenoActual += 1;
        }
        else
        {
            terrenoActual = 0;
        }
        if (terrenoActual > GameManager.instance.partidaGuardada.animalesEnTerrenos.Count)
        {
            terrenoActual = 0;
            return;
        }
            tamagochiSystem.personaje.tipoDeAnimal =
            GameManager.instance.partidaGuardada.animalesEnTerrenos[terrenoActual];
            tamagochiSystem.personaje.image.sprite = GameManager.instance.partidaGuardada.animalesEnTerrenos[terrenoActual].imagenAnimal;
    }
}

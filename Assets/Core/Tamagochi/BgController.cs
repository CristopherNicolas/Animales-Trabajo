using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using System.Threading.Tasks;
public class BgController : MonoBehaviour
{
   [SerializeField]SpriteRenderer bg,plataforma;
    public void AnimarColorBg() 
    {
       GameManager.instance.partidaGuardada.animalesEnTerrenos = new List<Animal>();
       GameManager.instance.partidaGuardada.animalesEnTerrenos.Add(GameManager.instance.cat);
            bg.DOColor(new Color(GameManager.instance.partidaGuardada.animalesEnTerrenos[0].colorParaBgSystem.r,
        GameManager.instance.partidaGuardada.animalesEnTerrenos[0].colorParaBgSystem.g,
        GameManager.instance.partidaGuardada.animalesEnTerrenos[0].colorParaBgSystem.b,1),15f);
    }
    public void CambiarBG(Animal animalActual)
    {
        bg.color = animalActual.colorParaBgSystem;
        plataforma.color = animalActual.colorPlataforma;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using System.Threading.Tasks;
public class BgController : MonoBehaviour
{
   [SerializeField]Image bg;
    public Animal animalSeleccionado;
    public async Task AnimarColorBg()
    {
        while (true)
        {
        bg.DOColor(new Color(bg.color.r, bg.color.g-0.5f, bg.color.b, bg.color.a), 30);
            await Task.Delay(System.TimeSpan.FromSeconds(30));
        bg.DOColor(animalSeleccionado.colorParaBgSystem, 30);
            await Task.Delay(System.TimeSpan.FromSeconds(30));
        }
    }
    public void CambiarBG(Animal animalActual)
    {
        bg.color = animalActual.colorParaBgSystem;
    }
}

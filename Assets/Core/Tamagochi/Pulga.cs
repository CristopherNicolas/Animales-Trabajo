using System.Collections;
using System.Threading.Tasks;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
/// <summary>
/// se crea dentro del minijuego de peinar y desaparecen a los 3 segundos mientas se desvanece
/// </summary>
public class Pulga : MonoBehaviour
{
    bool haSidoClickeada = false;
    private void Start()
    {
        StartCoroutine(DeadTime());
    }
    public IEnumerator DeadTime()
    {
        yield return new WaitForSecondsRealtime(3);
        if (gameObject != null)
        Destroy(gameObject);
    }
    public async void Clickear()
    {
        if (!haSidoClickeada)
        {
            haSidoClickeada=true;
            AudioManager.instance.PonerOneShotPulga();
            GameObject.Find("Tamagochi System").GetComponent<HerramientasTamagochi>().
            slider.value += 25;
            Debug.Log("pulga destruida");
            GetComponent<Image>().DOColor(new Color(0, 0, 0, 0), 1);
            GetComponent<RectTransform>().DOPunchScale(new Vector3(0.5f, 0.5f, 0.5f), 1);
            await Task.Delay(System.TimeSpan.FromSeconds(1));
            try
            {
            Destroy(gameObject);

            }
            catch (System.Exception)
            {
                
                throw;
            }
        }
        
    }
}

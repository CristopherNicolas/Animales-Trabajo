using System.Collections;
using System.Threading.Tasks;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
/// <summary>
/// se crea dentro del minijuego de peinar y desaparecen a los 3 segundos mientas se desvanece
/// </summary>
public class Pulga : MonoBehaviour
{
    bool haSidoClickeada = false;
    private void Start()
    {
        DeadTime();
    }
    public async void DeadTime()
    {
        await Task.Delay(System.TimeSpan.FromSeconds(3));
        Destroy(gameObject);
    }
    public async void Clickear()
    {
        if (!haSidoClickeada)
        {
            Debug.Log("pulga destruida");
            GetComponent<RectTransform>().DOPunchScale(new Vector3(0.5f, 0.5f, 0.5f), 1);
            await Task.Delay(System.TimeSpan.FromSeconds(1));
            Destroy(gameObject);
        }
        
    }
}

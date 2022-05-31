using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HambreYSed : MonoBehaviour
{
    public List<int> IndiceHambre, IndiceSed;
    public static HambreYSed instance;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }

    }

    // Start is called before the first frame update
    void Start()
    {
        IndiceHambre[0] = 10;
        IndiceHambre[1] = 10;
        IndiceHambre[2] = 10;
        IndiceHambre[3] = 10;
        IndiceHambre[4] = 10;
        IndiceHambre[5] = 10;
        IndiceSed[0] = 10;
        IndiceSed[1] = 10;
        IndiceSed[2] = 10;
        IndiceSed[3] = 10;
        IndiceSed[4] = 10;
        IndiceSed[5] = 10;
        StartCoroutine(RestarHambreSed());
    }

    IEnumerator RestarHambreSed()
    {
        yield return new WaitForSeconds(20f);
        IndiceHambre[0] -= Random.Range(1, 4);
        IndiceHambre[1] -= Random.Range(1, 4);
        IndiceHambre[2] -= Random.Range(1, 4);
        IndiceHambre[3] -= Random.Range(1, 4);
        IndiceHambre[4] -= Random.Range(1, 4);
        IndiceHambre[5] -= Random.Range(1, 4);
        IndiceSed[0] -= Random.Range(1, 4);
        IndiceSed[1] -= Random.Range(1, 4);
        IndiceSed[2] -= Random.Range(1, 4);
        IndiceSed[3] -= Random.Range(1, 4);
        IndiceSed[4] -= Random.Range(1, 4);
        IndiceSed[5] -= Random.Range(1, 4);
        StartCoroutine(RestarHambreSed());
    }
    public void Terreno1Hambre()
    {
        
    }
    public void Terreno2Hambre()
    {

    }
    public void Terreno3Hambre()
    {

    }
    public void Terreno4Hambre()
    {

    }
    public void Terreno5Hambre()
    {

    }
    public void Terreno6Hambre()
    {

    }
}

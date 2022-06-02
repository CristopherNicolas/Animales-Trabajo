using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class GotaAgua : MonoBehaviour
{
    private IEnumerator Start()
    {
        yield return new WaitForSecondsRealtime(5);
        Destroy(gameObject);
    }
    public void OnClicked()
    {
        UiSystem.instance.DarAgua(2);
        UiSystem.instance.UpdateUI();
        Destroy(gameObject);
    }
}

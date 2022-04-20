using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;
using TMPro;
using UnityEngine.UI;
public class MainMenu : MonoBehaviour
{
    public TMP_Text mainTitle;
    public Image bg;  
    public async void Start()
    {
        
         await Task.Delay(System.TimeSpan.FromSeconds(2.5f));
    }
}

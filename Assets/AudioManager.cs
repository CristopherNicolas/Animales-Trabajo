using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;
    public AudioClip comerGalleta,pulgaSound,uiSelect,gatoSound,irEscena1,irEscena2;
    public AudioSource audioSource;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
             DontDestroyOnLoad(gameObject);
        }
        else Destroy(gameObject);
        audioSource = GetComponent<AudioSource>();
    }
    public void PonerOneShotGalleta()=> audioSource.PlayOneShot(comerGalleta);
    public void PonerOneShotPulga()=> audioSource.PlayOneShot(pulgaSound);
    
}

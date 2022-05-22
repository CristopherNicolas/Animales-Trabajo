using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{    
    public void IrAEscena (int escenaIndex)=> SceneManager.LoadScene(escenaIndex);
}

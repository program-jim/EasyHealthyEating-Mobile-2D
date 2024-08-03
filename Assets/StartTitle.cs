using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartTitle : MonoBehaviour
{
    public StartManager startManager;
    
    public void LoadNextScene()
    {
        startManager.LoadNextScene();
    }
}

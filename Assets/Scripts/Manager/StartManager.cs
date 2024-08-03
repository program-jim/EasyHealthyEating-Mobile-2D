using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartManager : MonoBehaviour
{
    public LoadingBar loadingBar;
    public string loadSceneName = "Main";
    
    public void LoadNextScene()
    {
        loadingBar.StartLoading(loadSceneName);
    }
}

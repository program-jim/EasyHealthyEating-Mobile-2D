using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{
    public LoadingBar loadingBar;
    
    private void Awake() {
        
    }

    private void Start() {
        loadingBar.StartLoading("Main");
    }
}

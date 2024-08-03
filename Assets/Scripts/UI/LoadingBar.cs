using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class LoadingBar : MonoBehaviour
{
    public TextMeshProUGUI progressText;
    private Slider progressBar;
    public bool allowSceneActivation = true;
    
    void Awake() {
        progressBar = GetComponent<Slider>();
        progressText.text = 0 + "%";
        gameObject.SetActive(false);
    }
    
    public void StartLoading(string name)
    {
        gameObject.SetActive(true);
        StartCoroutine(Loading(name));
    }

    IEnumerator Loading(string name)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(name);
        operation.allowSceneActivation = allowSceneActivation;
        
        while (!operation.isDone)
        {
            progressBar.value = operation.progress;
            progressText.text = operation.progress * 100 + "%";

            if (operation.progress >= 0.9f)
            {
                progressBar.value = 1;
                progressText.text = 100 + "%";
            }

            yield return null;
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadGameScene : MonoBehaviour
{
    [SerializeField] private Button _startButon;
    [SerializeField] private Text _text;

    private void Awake()
    {
        _startButon.onClick.AddListener(LoadScene);
    }

    private void LoadScene()
    {
        StartCoroutine(LoadYourAsyncScene("Race"));
        _text.gameObject.SetActive(true);
    }
    
    public IEnumerator LoadYourAsyncScene(string sceneName)
    {
        
        AsyncOperation asyncLoad = UnityEngine.SceneManagement.SceneManager.LoadSceneAsync(sceneName);

        // Wait until the asynchronous scene fully loads
        while (!asyncLoad.isDone)
        {
            Debug.Log("Empiezo a cargar");
            yield return null;
        }
        
        Debug.Log("Termine de cargar el juego");
        
        asyncLoad.allowSceneActivation = true;
    }
}

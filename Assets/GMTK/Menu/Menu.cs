using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {
    AsyncOperation loadingScene;

    void Start () {
        loadingScene = SceneManager.LoadSceneAsync("Game - Copy");
        loadingScene.allowSceneActivation = false;
    }
	
	// Update is called once per frame
	void Update () {
    }

    public void OnStartClick()
    {
        loadingScene.allowSceneActivation = true;
    }

    public void OnExitClick()
    {
        Application.Quit();
    }
}

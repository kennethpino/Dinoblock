﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadNextScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene((currentSceneIndex + 1)%SceneManager.sceneCountInBuildSettings);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}

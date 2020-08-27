using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    int currentIndex;
    void Start()
    {
        currentIndex = SceneManager.GetActiveScene().buildIndex;
        if (currentIndex == 0)
        {
            StartCoroutine(LoadStartScene());
        }
    }
    IEnumerator LoadStartScene()
    {
        yield return new WaitForSeconds(4f);
        LoadNextScene();
        
    }
    public void LoadNextScene()
    {
        SceneManager.LoadScene(currentIndex + 1);
    }
    public void LoadYouLose()
    {
        SceneManager.LoadScene("Game Over");
    }
    public void quitting()
    {
        Application.Quit();
    }
    public void LoadLevel1()
    {
        SceneManager.LoadScene("Level 1");
    }
    
}

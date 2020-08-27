using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    int numberOfEnemies;
    bool LevelTimerFinished;
    [SerializeField] GameObject LevelCanvas;
    private void Start()
    {
        LevelCanvas.SetActive(false);
    }
    public void AddAttackers()
    {
        numberOfEnemies++;
    }
    public void RemoveAttackers()
    {
        numberOfEnemies--;
        if (numberOfEnemies <= 0 && LevelTimerFinished)
        {
            StartCoroutine(DisplayLevelWin());
        }
    }
    IEnumerator DisplayLevelWin()
    {
        LevelCanvas.SetActive(true);
        GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene("You Win");
    }
    public void LevelTimerEnd()
    {
        LevelTimerFinished = true;
        StopSpawners();
    }
    private void StopSpawners()
    {
        Spawner[] spawnerss = FindObjectsOfType<Spawner>();
        foreach(Spawner spaner in spawnerss)
        {
            spaner.StopSpawning();
        }
    }
}        
        
        

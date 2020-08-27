using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LivesDislay : MonoBehaviour
{
    [SerializeField] int Lifes = 11;
    Text LivesDisplayText;
    [SerializeField] int LifesTaken;
    void Start()
    {
        LivesDisplayText = gameObject.GetComponent<Text>();
        LivesDisplayText.text = Lifes.ToString();   
    }
    void Update()
    {
        LivesDisplayText.text = Lifes.ToString();
        if(Lifes <= 0)
        {
            FindObjectOfType<SceneLoader>().LoadYouLose();
        }
    }
    public void UpdateLifes()
    {
        Lifes -= LifesTaken;        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class starsDisplay : MonoBehaviour
{
    [SerializeField] int stars = 100;
    Text starText;
    void Start()
    {
        starText = GetComponent<Text>();
        UpdateStars();
    }

    private void UpdateStars()
    {
        starText.text = stars.ToString();
    }
    public void AddStars(int amount)
    {
        stars = stars + amount;
        UpdateStars();
    }
    public bool checkIfEnoughStars(int amount)
    {
        return stars >= amount;
    }
    public void SpendStars(int amount)
    {
        if (stars >= amount)
        {
            stars -= amount;
            UpdateStars();
        }
    }


    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defender : MonoBehaviour
{
    [SerializeField] int starcost = 100;
    public int starCost()
    {
        return starcost;
    }

    public void SetStarsToIncreaseInAnim(int starsIncreaseByTrophy)
    {
        FindObjectOfType<starsDisplay>().AddStars(starsIncreaseByTrophy);
    }

}

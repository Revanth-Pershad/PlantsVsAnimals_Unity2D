using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifesTaken : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        FindObjectOfType<LivesDislay>().UpdateLifes();
        GameObject EnemyCollided = collision.gameObject;
        Destroy(EnemyCollided, 0.5f);
    }
}

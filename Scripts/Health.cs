using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] float health = 30f;
    [SerializeField] GameObject deathVFX;

    public void DealDamage(float damage)
    {
        health -= damage;
        if (health <= 0)
        {
            GameObject DeathVFX = Instantiate(deathVFX, transform.position, Quaternion.identity);
            Destroy(gameObject);
            Destroy(DeathVFX, 1f);
        }
    }
}

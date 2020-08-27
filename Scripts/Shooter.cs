using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{

    [SerializeField] GameObject projectile, gunpoint;
    Spawner myLaneSpawwner;
    bool isCloseEnough;
    Animator animator;
    public void Fire()
    {
        Instantiate(projectile, gunpoint.transform.position, Quaternion.identity);
    }
    Spawner myLaneSpawner;

    private void Start()
    {
        SetLaneSpawner();
        animator = GetComponent<Animator>();
;    }

    private void Update()
    {
        if (IsAttackerInLane())
        {
            animator.SetBool("isAttacking", true);
        }
        else
        {
            animator.SetBool("isAttacking", false);
        }
    }

    private void SetLaneSpawner()
    {
        Spawner[] spawners = FindObjectsOfType<Spawner>();

        foreach (Spawner spawner in spawners)
        {
            bool IsCloseEnough =
                (Mathf.RoundToInt(spawner.transform.position.y - transform.position.y)
                <= 0);
            if (IsCloseEnough)
            {
                myLaneSpawner = spawner;
            }
        }
    }

    private bool IsAttackerInLane()
    {
        if (myLaneSpawner.transform.childCount <= 0)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
}

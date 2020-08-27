using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacker : MonoBehaviour
{
    float walkspeed = 0;
    GameObject currentTarget;
    private void Awake()
    {
        FindObjectOfType<LevelLoader>().AddAttackers();
    }
    private void OnDestroy()
    {
        LevelLoader level = FindObjectOfType<LevelLoader>();
        if(level != null)
        {
            level.RemoveAttackers();
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * walkspeed * Time.deltaTime);
        updateAttackig();
    }

    private void updateAttackig()
    {
        if (!currentTarget)
        {
            GetComponent<Animator>().SetBool("isAttacking", false);
        }
    }

    public void EnemyWalk(float speedy)
    {
        walkspeed = speedy;
    }
    public void AttackDefender(GameObject target)
    {
        GetComponent<Animator>().SetBool("isAttacking", true);
        currentTarget = target;
    }
    public void dealDamage(int damage)
    {
        if (!currentTarget) 
        { 
            return; 
        }
        Health health = currentTarget.GetComponent<Health>();
        if (health)
        {
            health.DealDamage(damage);
        }
    }
}

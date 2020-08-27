using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lizard : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D otheCollision)
    {
        GameObject defenderAttacked = otheCollision.gameObject;
        if (defenderAttacked.GetComponent<Defender>())
        {
            GetComponent<Attacker>().AttackDefender(defenderAttacked);
        }

    }
}

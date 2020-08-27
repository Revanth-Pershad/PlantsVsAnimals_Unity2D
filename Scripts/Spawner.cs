using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] float minSpawnDelay = 1f;
    [SerializeField] float maxSpawnDelay = 5f;
    [SerializeField] Attacker[] attackerPrefab;

    bool spawn = true;

    IEnumerator Start()
    {
        while (spawn)
        {
            yield return new WaitForSeconds(Random.Range(minSpawnDelay, maxSpawnDelay));
            SpawnAttacker();
        }
    }

    private void SpawnAttacker()
    {
        var SpawnerIndex = Random.Range(0, attackerPrefab.Length);
        Spawn(attackerPrefab[SpawnerIndex]);
    }

    void Spawn(Attacker thisAttacker)
    {
        Attacker newAttacker = Instantiate(thisAttacker, transform.position, transform.rotation) as Attacker;
        newAttacker.transform.parent = transform;
    }
    public void StopSpawning()
    {
        spawn = false;
    }
}

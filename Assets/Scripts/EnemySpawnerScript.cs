using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class  EnemySpawnerScript : MonoBehaviour
{
    public float spawnRadius = 20;
    public float time = 2f;
    public GameObject enemy;
    void Start()
    {
        StartCoroutine(Spawn());
    }

    IEnumerator Spawn()
    {
        Vector2 spawnPos = GameObject.Find("Player").transform.position;
        spawnPos += Random.insideUnitCircle.normalized * spawnRadius;
        Instantiate(enemy, spawnPos, Quaternion.identity);
            
        yield return new WaitForSeconds(time);
        StartCoroutine(Spawn());
    }
}

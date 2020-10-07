using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public float speed = 1f;
    public GameObject enemyProjectile;
    
    private Transform playerPos;

    void Awake()
    {
        playerPos = GameObject.Find("Player").transform;
    }
    
    void Start()
    {
        float delay = Random.Range(0.5f, 1.5f);
        float rate = Random.Range(.8f, 2f);
        InvokeRepeating("Fire", delay, rate);   
    }

    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, playerPos.position, speed * Time.deltaTime);
    }

    private void Fire()
    {
        int chance = Random.Range(1, 5);
        if (chance > 1)
        {
            Instantiate(enemyProjectile, transform.position, Quaternion.identity);
        }
    }
}

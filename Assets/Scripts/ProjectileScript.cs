using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileScript : MonoBehaviour
{
    public bool isEnem;
    public float lifetime = 5f;
    public float speed = 2f; //Enemy Projectile Speed

    private Rigidbody2D rb;
    private GameObject target;
    private Vector2 dir;

    private void Start()
    {
        Destroy(this.gameObject, lifetime);

        if (isEnem)
        {
            rb = GetComponent<Rigidbody2D>();
            target = GameObject.Find("Player");
            dir = (target.transform.position - this.transform.position).normalized * speed;
            rb.velocity = new Vector2(dir.x, dir.y);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        //if we're a player projectile
        if (!isEnem)
        {
            if (other.gameObject.CompareTag("Enemy"))
            {
                Destroy(other.gameObject);
                Destroy(this.gameObject);
            }
        }
        //otherwise we're an enemy projectile
        else
        {
            if (other.gameObject.CompareTag("Player"))
            {
                Destroy(this.gameObject);
                GameManagerScript.S.IncreaseMeter(5f);
            }
        }
    }
}

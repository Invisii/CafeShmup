using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private Transform playerPos;
    
    void Awake()
    {
        playerPos = GameObject.Find("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(playerPos.position.x, playerPos.position.y, transform.position.z);
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -10.2f, 10.2f), Mathf.Clamp(transform.position.y, -7.75f, 7.75f), transform.position.z);
    }
}

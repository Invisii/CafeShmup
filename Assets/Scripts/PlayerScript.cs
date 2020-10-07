using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public static float speed = 0.05f;
    public static float projSpeed = 10f;
    public KeyCode fire;
    public GameObject projPrefab;
    public float minPressTime, pressMeterInc;
    
    private float _xPos, _yPos;
    private float _shootInc = 2f;
    private float _wTime = 0f, _dTime = 0f, _aTime = 0f, _sTime = 0f;

    void Update()
    {
        //Move the Player
        if (Input.GetKey(KeyCode.D))
        {
            _xPos += speed;
        }
        if (Input.GetKey(KeyCode.A))
        {
            _xPos -= speed;
        }
        if (Input.GetKey(KeyCode.W))
        {
            _yPos += speed;
        }
        if (Input.GetKey(KeyCode.S))
        {
            _yPos -= speed;
        }
        
        //Shoot Projectile
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            GameObject proj = Instantiate(projPrefab, transform.position, Quaternion.identity);
            proj.GetComponent<Rigidbody2D>().velocity = new Vector2(0f, projSpeed);
            GameManagerScript.S.IncreaseMeter(_shootInc);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            GameObject proj = Instantiate(projPrefab, transform.position, Quaternion.identity);
            proj.GetComponent<Rigidbody2D>().velocity = new Vector2(0f, projSpeed*-1);
            GameManagerScript.S.IncreaseMeter(_shootInc);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            GameObject proj = Instantiate(projPrefab, transform.position, Quaternion.identity);
            proj.GetComponent<Rigidbody2D>().velocity = new Vector2(projSpeed, 0f);
            GameManagerScript.S.IncreaseMeter(_shootInc);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            GameObject proj = Instantiate(projPrefab, transform.position, Quaternion.identity);
            proj.GetComponent<Rigidbody2D>().velocity = new Vector2(projSpeed*-1, 0f);
            GameManagerScript.S.IncreaseMeter(_shootInc);
        }
        
        //Move player + Keep in Bounds
        transform.position = new Vector2(Mathf.Clamp(_xPos, -18.5f, 18.5f), Mathf.Clamp(_yPos, -12.4f, 12.4f));
        
        //Check how long a movement key was pressed
        if (Input.GetKeyDown(KeyCode.W))
        {
            _wTime = Time.time;
        }

        if (Input.GetKeyUp(KeyCode.W))
        {
            _wTime = Time.time - _wTime;
            if (_wTime <= minPressTime)
            {
                GameManagerScript.S.IncreaseMeter(pressMeterInc);
            }
        }
        
        if (Input.GetKeyDown(KeyCode.D))
        {
            _dTime = Time.time;
        }

        if (Input.GetKeyUp(KeyCode.D))
        {
            _dTime = Time.time - _dTime;
            if (_dTime <= minPressTime)
            {
                GameManagerScript.S.IncreaseMeter(pressMeterInc);
            }
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            _sTime = Time.time;
        }

        if (Input.GetKeyUp(KeyCode.S))
        {
            _sTime = Time.time - _sTime;
            if (_sTime <= minPressTime)
            {
                GameManagerScript.S.IncreaseMeter(pressMeterInc);
            }
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            _aTime = Time.time;
        }

        if (Input.GetKeyUp(KeyCode.A))
        {
            _aTime = Time.time - _aTime;
            if (_aTime <= minPressTime)
            {
                GameManagerScript.S.IncreaseMeter(pressMeterInc);
            }
        }
    }

    //When player goes to the pickup Counter
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Pickup"))
        {
            //get new coffee
        }
    }
}

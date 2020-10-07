using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class GameManagerScript : MonoBehaviour
{
    public float spillMax = 100; //Max level of the Spill Meter
    public float spillAmt = 75; //Level at which player will Spill
    public float spillLvl = 25; //Current level of the Spill Meter
    public Image spillMeter; //UI Meter

    public int totScore = 0; //Total Score
    public float cupScore; //Score for current cup
    public int drinks = 0; //total # scored drinks
    
    private float _defCupScore = 100f; //default score for new cup
    private int _spills = 0; //# spills on current cup

    public static GameManagerScript S;
    
    void Start()
    {
        S = this;
        spillMeter.fillAmount = spillLvl / spillMax;
    }

    void Update()
    {
        spillLvl -= 0.01f;
        spillMeter.fillAmount = spillLvl / spillMax;
    }

    public void IncreaseMeter(float amt)
    {
        spillLvl += amt;
        if (spillLvl >= spillAmt)
        {
            spillLvl -= spillMax / 2;
            cupScore -= Random.Range(1f, 2.5f) * _spills; 
            //Make a Spill Spot
        }
    }

    //Player scores carried coffee
    public void Dropoff()
    {
        totScore += (int) cupScore;
        drinks++;
        cupScore = _defCupScore;
        _spills = 0;
    }
    
}

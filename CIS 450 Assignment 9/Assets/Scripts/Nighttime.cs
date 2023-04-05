/*
 * EJ Flores
 * Nighttime.cs
 * Assignment 9
 * This script is a concrete state extending the weather interface. This is the nighttime state, setting the skybox to night/
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nighttime : MonoBehaviour, Weather
{
    WeatherController wc;

    public Nighttime(WeatherController wc)
    {
        this.wc = wc;
    }

    public void beCloudy()
    {
        throw new System.NotImplementedException();
    }

    public void beNight()
    {
        Debug.Log("NIGHT");
        RenderSettings.skybox = wc.night;
        wc.currentWeather = wc.nighttime;  
    }

    public void beSunny()
    {
        throw new System.NotImplementedException();
    }

    // Start is called before the first frame update
    void Start()
    {
        wc = GameObject.Find("WeatherController").GetComponent<WeatherController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

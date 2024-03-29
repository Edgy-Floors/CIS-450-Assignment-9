/*
 * EJ Flores
 * Sunny.cs
 * Assignment 9
 * This script is a concrete state extending the weather interface. This is the sunny interface, setting the skybox to sun.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sunny : MonoBehaviour, Weather
{
    WeatherController wc;

    public Sunny(WeatherController wc)
    {
        this.wc = wc;
    }

    public void beCloudy()
    {
        throw new System.NotImplementedException();
    }

    public void beNight()
    {
        throw new System.NotImplementedException();
    }

    public void beSunny()
    {
        Debug.Log("SUN");
        RenderSettings.skybox = wc.sun;
        wc.currentWeather = wc.sunny;
    }

    private void Start()
    {
        wc = GameObject.Find("WeatherController").GetComponent<WeatherController>();
    }
}

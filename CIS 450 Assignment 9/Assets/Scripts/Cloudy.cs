using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cloudy : MonoBehaviour, Weather
{
    WeatherController wc;

    public Cloudy(WeatherController wc)
    {
        this.wc = wc;
    }

    public void beCloudy()
    {
        Debug.Log("CLOUDS");
        RenderSettings.skybox = wc.cloud;
        wc.currentWeather = wc.cloudy;
    }

    public void beNight()
    {
        throw new System.NotImplementedException();
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

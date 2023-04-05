using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeatherController : MonoBehaviour
{
    public Weather sunny { get; set; }
    public Weather nighttime { get; set; }
    public Weather cloudy { get; set; }

    public Weather currentWeather { get; set; }

    public float time = 500;
    public bool isCloudy = false;

    public Material night;
    public Material sun;
    public Material cloud;

    private void Start()
    {
        sunny = gameObject.AddComponent<Sunny>();
        nighttime = gameObject.AddComponent<Nighttime>();
        cloudy = gameObject.AddComponent<Cloudy>();

        currentWeather = sunny;
    }

    public void beSunny() { currentWeather.beSunny(); }
    public void beCloudy() { currentWeather.beCloudy(); }
    public void beNight() { currentWeather.beNight(); }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            if(time >= 1000)
            {
                currentWeather = nighttime;
                beNight();
            }
            if(time <= 500)
            {
                if(isCloudy)
                {
                    currentWeather = cloudy;
                    beCloudy();
                } else
                {
                    currentWeather = sunny;
                    beSunny();
                }
            }
        }
        if(Input.GetKeyDown(KeyCode.Q))
        {
            time += 500;
            if(time > 1000)
            {
                time = 500;
            }
        }

        if(Input.GetKeyDown(KeyCode.R))
        {
            isCloudy = !isCloudy;
        }
    }
}

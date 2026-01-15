using UnityEngine;
using UnityEngine.Rendering;

public class DayNightCycle : MonoBehaviour
{
    public float dayDuration = 60f; // Duration of a full day in seconds
    public Camera mainCamera;

    private float timer;
    private bool isDay = true;
    private bool isNight;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        timer = dayDuration;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;

        if (timer <= 0 && isDay)
        {
            timer = dayDuration;
            isDay = false;
            isNight = true;
        }

        else if (timer <= 0 && isNight)
        {
            timer = dayDuration;
            isNight = false;
            isDay = true;
        }
    }
}

using UnityEngine;
using UnityEngine.Rendering;

public class DayNightCycle : MonoBehaviour
{
    public float dayDuration = 60f; // Duration of a full day in seconds
    public Camera mainCamera;

    private float timer;
    private bool isDay = true;
    private bool isNight;

    private Volume volume;
    //private vignette vignette;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        timer = dayDuration;
        volume = mainCamera.GetComponent<Volume>();
        //volume.profile.TryGet<Vignette>(out vignette);
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
            //vignette.intensity.value = 0.3f;
            //vignette.Rounded = false;
        }

        else if (timer <= 0 && isNight)
        {
            timer = dayDuration;
            isNight = false;
            isDay = true;
            //vignette.intensity.value = 1f;
            //vignette.Rounded = true;
        }

 
    }
}

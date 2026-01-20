using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class DayNightCycle : MonoBehaviour
{
    public float dayDuration = .1f; // Duration of a full day in seconds

    private float timer;
    private float nightDuration;

    private float transitionDuration; // Duration of the transition between day and night

    private bool isDay = true;
    private bool isNight;

    public Camera mainCamera;

    private Volume volume;
    private Vignette vignette;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        timer = (dayDuration * 60);
        nightDuration = (dayDuration * 60) / 2;
        volume = mainCamera.GetComponent<Volume>();
        volume.profile.TryGet<Vignette>(out vignette);
    }

    // Update is called once per frame
    void Update()
    {
        if (isNight)
        {
            nightDuration -= Time.deltaTime;

            if (nightDuration <= 0)
            {
                vignette.intensity.value = .3f;
                vignette.rounded.value = false;
                isNight = false;
                isDay = true;
                nightDuration = (dayDuration * 60) / 2;
            }
        }

        if (isDay)
        {
            timer -= Time.deltaTime;

            if (timer <= 0)
            {
                vignette.intensity.value = 1f;
                vignette.rounded.value = true;
                isDay = false;
                isNight = true;
                timer = (dayDuration * 60);
            }
        }

    }
}

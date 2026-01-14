using UnityEngine;

public class Swiming: MonoBehaviour
{
    private float timer;
    private Stats currentStats;

    public float coolDown = 1f;
    public float staminaDrainAmount = 5f;

    // Update is called once per frame
    void Update()
    {
        if (TryGetComponent(out Stats stats))
        {
            currentStats = stats;
        }

        if (currentStats.isSwimming)
        {
            timer -= Time.deltaTime;
            currentStats.speed = 2f;
        if (timer <= 0)
        {
                if (currentStats.stamina <= 0)
                { 
                    currentStats.health -= staminaDrainAmount;
                }
            currentStats.stamina -= staminaDrainAmount;
            timer = coolDown;
        }
        }
    }
}
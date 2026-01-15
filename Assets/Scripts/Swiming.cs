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
            currentStats.speed = 1f;
        if (timer <= 0)
        {
                if (currentStats.currentStamina <= 0)
                {
                    currentStats.currentHealth -= staminaDrainAmount;
                    currentStats.currentStamina = 0;
                }
                else
                {
                    currentStats.currentStamina -= staminaDrainAmount;
                }
            timer = coolDown;
        }
        }
        else
        {
            currentStats.speed = 3f;
        }
    }
}
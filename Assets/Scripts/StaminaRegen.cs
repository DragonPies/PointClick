using UnityEngine;

public class StaminaRegen : MonoBehaviour
{
    private float timer;
    private Stats currentStats;

    public float coolDown = 1f;
    public float staminaRegenAmount = 5f;

    // Update is called once per frame
    void Update()
    {
        if (TryGetComponent(out Stats stats))
        {
            currentStats = stats;
        }

        if (!currentStats.isSwimming)
        {
            timer -= Time.deltaTime;

            if (timer <= 0)
            {
                currentStats.currentStamina += staminaRegenAmount;
                timer = coolDown;
            }

        }
    }
}

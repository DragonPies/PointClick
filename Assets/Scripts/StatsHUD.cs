using UnityEngine;
using UnityEngine.UI;

public class StatsHUD : MonoBehaviour
{
    public Stats stats;

    public Image healthBar;
    public Image staminaBar;


    private void Start()
    {
       stats = GameObject.FindWithTag("Player").GetComponent<Stats>();
    }

    // Update is called once per frame
    void Update()
    {
        healthBar.fillAmount = stats.currentHealth / stats.health;
        staminaBar.fillAmount = stats.currentStamina / stats.stamina;
    }
}
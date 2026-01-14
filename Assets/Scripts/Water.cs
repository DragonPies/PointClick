using UnityEngine;

public class Water : MonoBehaviour
{

    Stats playerStats;

    private void Update()
    {

    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        playerStats = collision.GetComponent<Stats>();
        playerStats.isSwimming = true;


    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        playerStats = collision.GetComponent<Stats>();
        playerStats.isSwimming = false;
    }
}

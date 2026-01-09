using System.Collections.Generic;
using UnityEngine;

public class Mineables : MonoBehaviour
{
    [Header("What Is It?")]
    public bool rock;
    public bool tree;

    public int materialHealth = 3;
    public int hardness;

    public Stats playerStats;

   

    
    void Start()
    {
        playerStats = GameObject.FindWithTag("Player").GetComponent<Stats>();
    }

        private void Update()
        {
            if (materialHealth <= 0)
            {
                if (rock)
                {
                playerStats.stoneCount += 1;
                }

                else if (tree)
                {
                playerStats.woodCount += 1;
                }
                Destroy(gameObject);
            }
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            
            if (Input.GetMouseButtonDown(0) && hardness <= playerStats.breakPower)
            {
                materialHealth -= playerStats.damage;
            }
        }
    }

}

using BarthaSzabolcs.Tutorial_SpriteFlash;
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

   public SimpleFlash SimpleFlash;


    void Start()
    {
        playerStats = GameObject.FindWithTag("Player").GetComponent<Stats>();
        gameObject.GetComponent<SimpleFlash>();
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
            
            if (Input.GetMouseButtonDown(0))
            {
                
                if (rock && playerStats.pickBreakPower >= hardness)
                {
                    materialHealth -= playerStats.pickDamage;
                    SimpleFlash.Flash();
                }
                else if (tree && playerStats.axeBreakPower >= hardness)
                {
                    materialHealth -= playerStats.axeDamage;
                    SimpleFlash.Flash();
                }
                
            }
        }
    }

}

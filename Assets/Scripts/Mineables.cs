using BarthaSzabolcs.Tutorial_SpriteFlash;
using System.Collections.Generic;
using UnityEngine;

public class Mineables : MonoBehaviour
{
    [Header("StoneLike Mineables")]
    public bool rock;
    public bool coal;
    public bool iron;

    [Header("TreeLike Mineables")]
    public bool tree;
    public bool oak;
    public bool pine;

    [Header("Mineable Stats")]
    public int materialHealth = 3;
    public int hardness;

    [Header("Player Stats Reference / Flash Frame")]
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

    public void TakeDamage()
    {
        if (rock && playerStats.pickBreakPower >= hardness)
        {
            materialHealth -= playerStats.pickDamage;
            SimpleFlash.Flash();
        }
        
        if (tree && playerStats.axeBreakPower >= hardness)
        {
            materialHealth -= playerStats.axeDamage;
            SimpleFlash.Flash();
        }
    }

}

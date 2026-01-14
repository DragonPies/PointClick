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
    public float staminaDrain;

    [Header("Player Stats Reference / Flash Frame")]
    public Stats playerStats;
    public SimpleFlash SimpleFlash;
    public Transform currentPoint;
    private Vector3 SetZ(Vector3 vector, float z)
    {
        return vector;
    }
    
    void Start()
    {
        playerStats = GameObject.FindWithTag("Player").GetComponent<Stats>();
        gameObject.GetComponent<SimpleFlash>();

        currentPoint = gameObject.GetComponent<Transform>();

    }

        private void Update()
        {
            currentPoint.transform.position = SetZ(currentPoint.position, 0);
       

        if (materialHealth <= 0)
            {
                playerStats.currentStamina -= staminaDrain;
            if (rock)
                {
                playerStats.stoneCount += 1;
                }

                if (coal)
                { 
                    playerStats.coalCount += 1;
                }

                if (iron)
                { 
                    playerStats.ironCount += 1;
                }

                if (tree)
                {
                playerStats.woodCount += 1;
                }

                if (pine)
                {
                    playerStats.pineCount += 1;
                }

                if (oak)
                {
                    playerStats.oakCount += 1;
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
        
        if (coal && playerStats.pickBreakPower >= hardness)
        {
            materialHealth -= playerStats.pickDamage;
            SimpleFlash.Flash();
        }

        if (iron && playerStats.pickBreakPower >= hardness)
        {
            materialHealth -= playerStats.pickDamage;
            SimpleFlash.Flash();
        }

        if (tree && playerStats.axeBreakPower >= hardness)
        {
            materialHealth -= playerStats.axeDamage;
            SimpleFlash.Flash();
        }

        if (pine && playerStats.axeBreakPower >= hardness)
        {
            materialHealth -= playerStats.axeDamage;
            SimpleFlash.Flash();
        }

        if (oak && playerStats.axeBreakPower >= hardness)
        {
            materialHealth -= playerStats.axeDamage;
            SimpleFlash.Flash();
        }
    }

}

using System.Collections.Generic;
using UnityEngine;

public class Mineables : MonoBehaviour
{
    [Header("What Is It?")]
    public bool rock;
    public bool tree;

    public int materialHealth = 3;

    public Stats playerStats;

    [Header("UI Values")]
    public MatsUI UI;

    
    void Start()
    {
        UI = GameObject.Find("MatsHUD").GetComponent<MatsUI>();
        playerStats = GameObject.FindWithTag("Player").GetComponent<Stats>();
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            
            if (Input.GetMouseButtonDown(0))
            {
                if (rock)
                {
                    Debug.Log("Rock mined");
                    UI.stoneCount += 1;
                }

                if (tree)
                {
                    Debug.Log("Tree mined");
                    UI.woodCount += 1;
                }

                Destroy(this.gameObject);
            }
        }
    }

}

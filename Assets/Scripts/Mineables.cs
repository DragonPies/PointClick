using System.Collections.Generic;
using UnityEngine;

public class Mineables : MonoBehaviour
{
    public bool rock;
    public bool tree;

    public MatsUI UI;
    void Start()
    {
        UI = GameObject.Find("MatsHUD").GetComponent<MatsUI>();
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

                Destroy(this.gameObject);
            }
        }
    }
}

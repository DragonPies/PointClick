using UnityEngine;

public class Mats : MonoBehaviour
{
    public TMPro.TextMeshProUGUI CountText;
    public Stats UI;
    public bool isStone;
    public bool isWood;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        UI = GameObject.Find("Player 1").GetComponent<Stats>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isStone)
        {
            CountText.text = UI.stoneCount.ToString();
        }

        else if (isWood)
        {
            CountText.text = UI.woodCount.ToString();
        }

    }
}

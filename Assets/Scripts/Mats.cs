using UnityEngine;

public class Mats : MonoBehaviour
{
    public TMPro.TextMeshProUGUI CountText;
    public Stats UI;

    [Header("Material Type-Rocks")]
    public bool isStone;
    public bool isCoal;
    public bool isIron;

    [Header("Material Type-Trees")]
    public bool isWood;
    public bool isPine;
    public bool isOak;

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

        if (isCoal)
        {
            CountText.text = UI.coalCount.ToString();
        }

        if (isIron)
        {
            CountText.text = UI.ironCount.ToString();
        }

        if (isWood)
        {
            CountText.text = UI.woodCount.ToString();
        }

        if (isPine)
        {
            CountText.text = UI.pineCount.ToString();
        }

        if (isOak)
        {
            CountText.text = UI.oakCount.ToString();
        }

    }
}

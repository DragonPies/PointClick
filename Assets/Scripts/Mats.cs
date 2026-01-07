using UnityEngine;

public class Mats : MonoBehaviour
{
    public TMPro.TextMeshProUGUI CountText;
    public MatsUI UI;
    public bool isStone;
    public bool isWood;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        UI = GameObject.Find("MatsHUD").GetComponent<MatsUI>();
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

using UnityEngine;

public class button : MonoBehaviour
{
    public TMPro.TMP_Text buttonText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        buttonText.text = "Buy";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnBuy()
    {
        buttonText.text = "Bought";
    }
}


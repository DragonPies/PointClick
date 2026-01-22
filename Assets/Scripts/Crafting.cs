using UnityEngine;

public class Crafting : MonoBehaviour
{
    public GameObject craftingUI;

    private void Update()
    {
        if (craftingUI.activeSelf)
        { 
            Time.timeScale = 0f;
        }
        else
        {
            Time.timeScale = 1f;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        craftingUI.SetActive(true);
    }

    
}

using UnityEngine;

public class Crafting : MonoBehaviour
{
    public GameObject craftingUI;

    void Start()
    {
        if (craftingUI = null)
        {
            craftingUI = GameObject.Find("CraftingMenu");
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        craftingUI.SetActive(true);
    }
}

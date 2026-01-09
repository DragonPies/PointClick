using UnityEngine;

public class Crafting : MonoBehaviour
{
    public GameObject craftingUI;

    void Start()
    {
     
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        craftingUI.SetActive(true);
    }
}

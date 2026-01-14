using UnityEngine;

public class Inventory : MonoBehaviour
{
    public GameObject inventoryUI;
    public bool isOpen = false;

    private void Start()
    {
        inventoryUI = GameObject.Find("Inventory");
    }
    public void OpenInventory()
   {
        if (!isOpen)
        {
            // Code to open the inventory UI
            Debug.Log("Inventory opened.");
            Time.timeScale = 0f; // Pause the game
            inventoryUI.SetActive(true);
            isOpen = true;
        }

        else if (isOpen)
        {
            CloseInventory();
        }


    }

    public void CloseInventory()
    {
        // Code to close the inventory UI
        Debug.Log("Inventory closed.");
        Time.timeScale = 1f; // Resume the game
        inventoryUI.SetActive(false);
        isOpen = false;
    }
}

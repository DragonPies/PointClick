using UnityEngine;

public class Inventory : MonoBehaviour
{
    public GameObject inventoryUI;
    private bool isOpen;

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
          inventoryUI.SetActive(false);
        isOpen = false;
    }
}

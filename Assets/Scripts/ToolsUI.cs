using UnityEngine;
using UnityEngine.UI;

public class ToolsUI : MonoBehaviour

{
    [Header("Pickaxes")]
    public GameObject pick;
    public Sprite woodenPick;
    public Sprite stonePick;

    [Header("Axes")]
    public GameObject axe;
    public Sprite woodenAxe;
    public Sprite stoneAxe;



    public CraftingShop toolUI;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        pick.GetComponent<Image>().color = Color.clear;
        axe.GetComponent<Image>().color = Color.clear;
    }

    // Update is called once per frame
    void Update()
    {
        if (toolUI.woodenPickBought)
        { 
            pick.GetComponent<Image>().color = Color.white;
            pick.GetComponent<Image>().sprite = woodenPick;
        }
        else if (toolUI.stonePickBought)
        { 
            pick.GetComponent<Image>().color = Color.white;
            pick.GetComponent<Image>().sprite = stonePick;
        }
        else if (toolUI.woodenAxeBought)
        { 
            axe.GetComponent<Image>().color = Color.white;
            axe.GetComponent<Image>().sprite = woodenAxe;
        }
        else if (toolUI.stoneAxeBought)
        { 
            axe.GetComponent<Image>().color = Color.white;
            axe.GetComponent<Image>().sprite = stoneAxe;
        }
    }
}

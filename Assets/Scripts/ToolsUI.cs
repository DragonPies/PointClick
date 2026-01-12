using UnityEngine;
using UnityEngine.UI;

public class ToolsUI : MonoBehaviour

{
    [Header("Swords")]
    public GameObject sword;
    public Sprite woodenSword;
    public Sprite stoneSword;

    [Header("Shields")]
    public GameObject shield;
    public Sprite woodenShield;
    public Sprite stoneShield;

    [Header("Pickaxes")]
    public GameObject pick;
    public Sprite woodenPick;
    public Sprite stonePick;

    [Header("Axes")]
    public GameObject axe;
    public Sprite woodenAxe;
    public Sprite stoneAxe;

    [Header("Misc")]
    public CraftingShop toolUI;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        pick.GetComponent<Image>().color = Color.clear;
        axe.GetComponent<Image>().color = Color.clear;
        sword.GetComponent<Image>().color = Color.clear;
        shield.GetComponent<Image>().color = Color.clear;
    }

    // Update is called once per frame
    void Update()
    {
        if (toolUI.woodenSwordBought)
        { 
            sword.GetComponent<Image>().color = Color.white;
            sword.GetComponent<Image>().sprite = woodenSword;
        }

        if (toolUI.stoneSwordBought)
        { 
            sword.GetComponent<Image>().color = Color.white;
            sword.GetComponent<Image>().sprite = stoneSword;
        }

        if (toolUI.woodenShieldBought)
        { 
            shield.GetComponent<Image>().color = Color.white;
            shield.GetComponent<Image>().sprite = woodenShield;
        }

        if (toolUI.stoneShieldBought)
        { 
            shield.GetComponent<Image>().color = Color.white;
            shield.GetComponent<Image>().sprite = stoneShield;
        }

        if (toolUI.woodenPickBought)
        { 
            pick.GetComponent<Image>().color = Color.white;
            pick.GetComponent<Image>().sprite = woodenPick;
        }

        if (toolUI.stonePickBought)
        { 
            pick.GetComponent<Image>().color = Color.white;
            pick.GetComponent<Image>().sprite = stonePick;
        }

        if (toolUI.woodenAxeBought)
        { 
            axe.GetComponent<Image>().color = Color.white;
            axe.GetComponent<Image>().sprite = woodenAxe;
        }

        if (toolUI.stoneAxeBought)
        { 
            axe.GetComponent<Image>().color = Color.white;
            axe.GetComponent<Image>().sprite = stoneAxe;
        }
    }
}

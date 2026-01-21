using UnityEngine;
using UnityEngine.UI;

public class ToolsUI : MonoBehaviour

{
    [Header("Swords")]
    public GameObject sword;
    public Sprite woodenSword;
    public Sprite stoneSword;
    public Sprite ironSword;

    [Header("Shields")]
    public GameObject shield;
    public Sprite woodenShield;
    public Sprite stoneShield;
    public Sprite ironShield;

    [Header("Pickaxes")]
    public GameObject pick;
    public Sprite woodenPick;
    public Sprite stonePick;
    public Sprite ironPick;

    [Header("Axes")]
    public GameObject axe;
    public Sprite woodenAxe;
    public Sprite stoneAxe;
    public Sprite ironAxe;

    [Header("Misc")]
    public CraftingShop toolUI;
    public CraftingShop combatUI;
    public CraftingShop structureUI;

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
        if (combatUI.woodenSwordBought)
        { 
            sword.GetComponent<Image>().color = Color.white;
            sword.GetComponent<Image>().sprite = woodenSword;
        }

        if (combatUI.stoneSwordBought)
        { 
            sword.GetComponent<Image>().color = Color.white;
            sword.GetComponent<Image>().sprite = stoneSword;
        }

        if (combatUI.ironSwordBought)
        { 
            sword.GetComponent<Image>().color = Color.white;
            sword.GetComponent<Image>().sprite = ironSword;
        }

        if (combatUI.woodenShieldBought)
        { 
            shield.GetComponent<Image>().color = Color.white;
            shield.GetComponent<Image>().sprite = woodenShield;
        }

        if (combatUI.stoneShieldBought)
        { 
            shield.GetComponent<Image>().color = Color.white;
            shield.GetComponent<Image>().sprite = stoneShield;
        }

        if (combatUI.ironShieldBought)
        { 
            shield.GetComponent<Image>().color = Color.white;
            shield.GetComponent<Image>().sprite = ironShield;
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

        if (toolUI.ironPickBought)
        { 
            pick.GetComponent<Image>().color = Color.white;
            pick.GetComponent<Image>().sprite = ironPick;
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

        if (toolUI.ironAxeBought)
        { 
            axe.GetComponent<Image>().color = Color.white;
            axe.GetComponent<Image>().sprite = ironAxe;
        }
    }
}

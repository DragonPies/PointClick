using UnityEngine;
using UnityEngine.UI;

public class CraftingShop : MonoBehaviour
{
    public TMPro.TextMeshProUGUI buyText;
    public Stats stats;

    private bool hasBought;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BuyWoodenPick()
    {
        

        if (stats.woodCount >= 5 && !hasBought)
        {
            buyText.text = "Bought";
            stats.woodCount -= 5;
            stats.pickBreakPower = 2;
            stats.pickDamage = 2;
            hasBought = true;
        }
    }

    public void BuyWoodenAxe()
    {
        if (stats.woodCount >= 5 && !hasBought)
        {
            buyText.text = "Bought";
            stats.woodCount -= 5;
            stats.axeBreakPower = 2;
            stats.axeDamage = 2;
            hasBought = true;
        }
    }
    public void BuyStonePick()
    {


        if (stats.stoneCount >= 10 && stats.woodCount >= 5 && !hasBought)
        {
            buyText.text = "Bought";
            stats.stoneCount -= 10;
            stats.woodCount -= 5;
            stats.pickBreakPower = 3;
            stats.pickDamage = 3;
            hasBought = true;
            
        }

   
    }

    public void BuyStoneAxe()
    {


        if (stats.stoneCount >= 10 && stats.woodCount >= 5 && !hasBought)
        {
            buyText.text = "Bought";
            stats.stoneCount -= 10;
            stats.woodCount -= 5;
            stats.axeBreakPower = 3;
            stats.axeDamage = 3;
            hasBought = true;
            
        }
    }


}

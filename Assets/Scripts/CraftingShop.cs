using UnityEngine;
using UnityEngine.UI;

public class CraftingShop : MonoBehaviour
{
    public Stats stats;

    [Header("Item Purchase Status")]
    public bool woodenPickBought;
    public bool woodenAxeBought;
    public bool stonePickBought;
    public bool stoneAxeBought;


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
        

        if (stats.woodCount >= 5 && !woodenPickBought)
        {
            stats.woodCount -= 5;
            stats.pickBreakPower = 2;
            stats.pickDamage = 2;
            woodenPickBought = true;
            stonePickBought = false;
        }
    }

    public void BuyWoodenAxe()
    {
        if (stats.woodCount >= 5 && !woodenAxeBought)
        {
            stats.woodCount -= 5;
            stats.axeBreakPower = 2;
            stats.axeDamage = 2;
            woodenAxeBought = true;
            stoneAxeBought = false;
        }
    }
    public void BuyStonePick()
    {


        if (stats.stoneCount >= 10 && stats.woodCount >= 5 && !stonePickBought)
        {
            stats.stoneCount -= 10;
            stats.woodCount -= 5;
            stats.pickBreakPower = 3;
            stats.pickDamage = 3;
            stonePickBought = true;
            woodenPickBought = false;

        }

   
    }

    public void BuyStoneAxe()
    {


        if (stats.stoneCount >= 10 && stats.woodCount >= 5 && !stoneAxeBought)
        {
            stats.stoneCount -= 10;
            stats.woodCount -= 5;
            stats.axeBreakPower = 3;
            stats.axeDamage = 3;
            stoneAxeBought = true;
            woodenAxeBought = false;

        }
    }


}

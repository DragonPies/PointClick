using UnityEngine;
using UnityEngine.UI;

public class CraftingShop : MonoBehaviour
{
    public Stats stats;

    public GameObject craftingTable;

    [Header("Item Purchase Status")]
    public bool woodenSwordBought;

    public bool woodenShieldBought;

    public bool woodenPickBought;

    public bool woodenAxeBought;

    public bool stoneSwordBought;

    public bool stoneShieldBought;

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

    public void SpawnCraftingTable()
    {
        craftingTable.GetComponent<SpriteRenderer>().color = Color.white;
        Instantiate(craftingTable, stats.currentPoint.transform.position, Quaternion.identity);
    }

    public void BuyWoodenSword()
    {
        if (stats.woodCount >= 10 && !woodenSwordBought)
        {
            stats.woodCount -= 10;
            stats.atkdamage = 2;
            woodenSwordBought = true;
            stoneSwordBought = false;
        }
    }

    public void BuyWoodenShield()
    {
        if (stats.woodCount >= 8 && !woodenShieldBought)
        {
            stats.woodCount -= 8;
            stats.defense = 5;
            woodenShieldBought = true;
            stoneShieldBought = false;
        }
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

    public void BuyStoneSword()
    {
        if (stats.woodCount >= 10 && stats.stoneCount >= 15 && !stoneSwordBought)
        {
            stats.woodCount -= 10;
            stats.atkdamage = 3;
            woodenSwordBought = false;
            stoneSwordBought = true;
        }
    }

    public void BuyStoneShield()
    {
        if (stats.woodCount >= 8 && stats.stoneCount >= 12 && !stoneShieldBought)
        {
            stats.woodCount -= 8;
            stats.stoneCount -= 12;
            stats.defense = 10;
            woodenShieldBought = false;
            stoneShieldBought = true;
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

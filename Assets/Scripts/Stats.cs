using UnityEngine;

public class Stats : MonoBehaviour
{
    [Header("Main Stats")]
    public int health = 100;
    public int stamina = 100;
    public float speed = 5f;

    [Header("Combat Stats")]
    public int atkdamage = 1;
    public int defense = 0;

    [Header("Pickaxe Tool Stats")]
    public int pickBreakPower;
    public int pickDamage;

    [Header("Axe Tool Stats")]
    public int axeBreakPower = 1;
    public int axeDamage = 1;

    [Header("Resource Counts")]
    public int stoneCount;
    public int woodCount;

}

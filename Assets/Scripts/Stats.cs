using UnityEngine;

public class Stats : MonoBehaviour
{
    [Header("Main Stats")]
    public float health = 100;
    public float stamina = 100;
    public float currentStamina;
    public float speed = 5f;

    [Header("States of person")]
    public bool isRunning;
    public bool isSwimming;
    public bool isAlive;

    [Header("Combat Stats")]
    public int atkdamage = 1;
    public int defense = 0;

    [Header("Pickaxe Tool Stats")]
    public int pickBreakPower;
    public int pickDamage;

    [Header("Axe Tool Stats")]
    public int axeBreakPower = 1;
    public int axeDamage = 1;

    [Header("Resource Stones")]
    public int stoneCount;
    public int coalCount;
    public int ironCount;

    [Header("Resource Woods")]
    public int woodCount;
    public int pineCount;
    public int oakCount;




    void Start()
    {
        isAlive = true;
        isRunning = false;
        isSwimming = false;
    }

}

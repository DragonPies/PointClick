using UnityEngine;
using UnityEngine.InputSystem;

public class Mining : MonoBehaviour
{
    public float attackRadius = 1f;
    public float staminaCost = 5f;
    public LayerMask attackLayer;

    private PlayerMovement topDown;
    private Stats currentStats;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        topDown = GetComponent<PlayerMovement>();
    }

    private void Update()
    {
        /*if (TryGetComponent(out ManaDrain manaDrains))
        {
            manaDrain = manaDrains;
        }
        */
        if (TryGetComponent(out Stats stats))
        {
            currentStats = stats;
        }
    }

    private void OnValidate()
    {
        topDown = GetComponent<PlayerMovement>();
    }


    public void Attack(InputAction.CallbackContext ctx)
    {
        if (ctx.ReadValue<float>() == 0)
            return;

        RaycastHit2D hit = Physics2D.CircleCast(transform.position, attackRadius, Vector2.zero, 0, attackLayer);

        if (hit)
        {
            Debug.Log(hit.collider.gameObject.name);
            if (hit.collider.TryGetComponent(out Mineables targetMineable) && currentStats.currentStamina >= staminaCost)
            {
                currentStats.currentStamina -= staminaCost;
                targetMineable.TakeDamage();
            }
            

            /*if (hit.collider.TryGetComponent(out Stats targetStats) && TryGetComponent(out Stats playerStats))
            {
                //float calculatedDamage = playerStats.atkdamage - targetStats.defense;
                //targetStats.currentHealth -= calculatedDamage;
            }
            */
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(transform.position, attackRadius);
    }
}
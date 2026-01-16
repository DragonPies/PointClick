using UnityEngine;
using System.Collections;
using NUnit.Framework;
using System.Collections.Generic;

public class PlayerMovement : MonoBehaviour
{
    public static List<PlayerMovement> moveableObjects = new List<PlayerMovement>();
    public Vector2 targetPosition;
    public Rigidbody2D _playerRB2D;

    public Stats playerStats;


    public Animator _anim;
    private bool selected;

    private void Awake()
    {
        _anim = GetComponent<Animator>();
        
    }

    void Start()
    {
        moveableObjects.Add(this);
        targetPosition = transform.position;
        playerStats = GetComponent<Stats>();
    }
    void Update()
    {

        if (Vector2.Distance(transform.position, targetPosition) > 0.1f)
        {
            _playerRB2D.linearVelocity = (targetPosition - (Vector2)transform.position).normalized * playerStats.speed;

            _anim.SetFloat("x", _playerRB2D.linearVelocity.normalized.x);
            _anim.SetFloat("y", _playerRB2D.linearVelocity.normalized.y);
        }
        else
        {
            _playerRB2D.linearVelocity = Vector2.zero;
        }


        if (Input.GetMouseButtonDown(1) /*&& selected*/)
        {
            Move();
        }

    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Mineable"))
        {
            Debug.Log("Collided with Mineable, stopping movement");
            _playerRB2D.linearVelocity = Vector2.zero;
            targetPosition = transform.position;
        }
    }

   

    public void Run()
    { 
        playerStats.isRunning = true;
    }

    private void Move()
    {
        targetPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        
    }

    /*
        private void OnMouseDown()
        {
            Debug.Log("Object Selected");
            selected = true;
            gameObject.GetComponent<SpriteRenderer>().color = Color.magenta;

            foreach(PlayerMovement obj in moveableObjects)
            {
                if (obj != this)
                {
                    obj.selected = false;
                    obj.gameObject.GetComponent<SpriteRenderer>().color = Color.white;
                }
            }
        }

        */
}
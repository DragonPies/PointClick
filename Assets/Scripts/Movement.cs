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

    private Animator _anim;
    private bool selected;

    void Start()
    {
        moveableObjects.Add(this);
        targetPosition = transform.position;
        playerStats = GameObject.FindWithTag("Player").GetComponent<Stats>();
        _anim = GetComponent<Animator>();
    }
    void Update()
    {

        if (Input.GetMouseButtonDown(1) && selected)
        {
            targetPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }
            _anim.SetFloat("x", _playerRB2D.linearVelocityX);
            _anim.SetFloat("y", _playerRB2D.linearVelocityY);
            transform.position = Vector2.MoveTowards(transform.position, targetPosition, Time.deltaTime * playerStats.speed);


        


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

    public void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Mineable"))
        {
            Debug.Log("Staying in collision with Mineable, stopping movement");
            _playerRB2D.linearVelocity = Vector2.zero;
            targetPosition = transform.position;
        }
    }


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

    
}
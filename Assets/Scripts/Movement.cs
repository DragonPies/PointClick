using UnityEngine;
using System.Collections;
using NUnit.Framework;
using System.Collections.Generic;

public class PlayerMovement : MonoBehaviour
{
    public static List<PlayerMovement> moveableObjects = new List<PlayerMovement>();
    public Vector2 targetPosition;
    public Rigidbody2D _playerRB2D;
    public float speed;

    private Animator _anim;
    private bool selected;

    void Start()
    {
        moveableObjects.Add(this);
        targetPosition = transform.position;
    }
    void Update()
    {

        if (Input.GetMouseButtonDown(1) && selected)
        {
            targetPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            _anim.SetFloat("x", _playerRB2D.linearVelocityX);
            _anim.SetFloat("y", _playerRB2D.linearVelocityY);
        }

        transform.position = Vector2.MoveTowards(transform.position, targetPosition, Time.deltaTime * speed);

        

    }

    private void OnMouseDown()
    {
        Debug.Log("Object Selected");
        selected = true;
        gameObject.GetComponent<SpriteRenderer>().color = Color.yellow;

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
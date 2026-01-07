using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{

    public Vector2 targetPosition;
    public Rigidbody2D _playerRB2D;

    private Animator _anim;

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            targetPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            _anim.SetFloat("x", _playerRB2D.linearVelocityX);
            _anim.SetFloat("y", _playerRB2D.linearVelocityY);
        }

        transform.position = Vector2.MoveTowards(transform.position, targetPosition, Time.deltaTime * 5);

        

    }
}
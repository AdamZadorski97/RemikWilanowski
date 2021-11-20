using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed;
    public float jumpForce;
    public SpriteRenderer spriteRenderer;
    public Rigidbody2D playerRigidbody2D;



    private void Start()
    {
        playerRigidbody2D.gravityScale = 10;
    }

    public void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.D))
        {
            MovePlayer(Vector3.right);
        }
        if (Input.GetKey(KeyCode.A))
        {
            MovePlayer(Vector3.left);
        }
        if(Input.GetKeyDown(KeyCode.W))
        {
            playerRigidbody2D.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
        }
    }

    public void MovePlayer(Vector3 direction)
    {
        transform.position += direction * moveSpeed;
    }

}

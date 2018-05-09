using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MoveRigidbody : MonoBehaviour
{
    public float speed;
    public float rotation;

    private Rigidbody2D _rigidbody; 

    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();

    }

    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
       // float moveVertical = Input.GetAxis("Vertical");

        Vector2 movement = new Vector2(moveHorizontal, 1);
        _rigidbody.velocity = movement * speed;


        if (moveHorizontal > 0)
        {
            transform.Rotate(0, 0, rotation);
        }
        else if (moveHorizontal < 0)
        {
            transform.Rotate(0, 0, -rotation);
        }

    }
}
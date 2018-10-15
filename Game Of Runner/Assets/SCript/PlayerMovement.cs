using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public static float speed = 350f;
    public static float jumpForce = 400f;
    public static Rigidbody2D rb2d;
    public static SpriteRenderer SR;
    public static Vector2 movement;

    void Start() { rb2d = GetComponent<Rigidbody2D>(); SR = GetComponent<SpriteRenderer>(); SR.color = Color.red; }


    void Update()
    {
        movement = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        rb2d.velocity = new Vector2(movement.x * speed * Time.deltaTime, rb2d.velocity.y);

    }
}
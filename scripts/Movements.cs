using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movements : MonoBehaviour
{
    private Rigidbody2D rb;
    //the horizontal speed of the player
    public float speed;
   //getting the rigidbody2d (rb) component
    void Start() { rb = GetComponent<Rigidbody2D>(); }

   //doing the movement things 
    void Update()
    {
        float moveInputValue = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveInputValue * speed * Time.deltaTime,rb.velocity.y);
        if(moveInputValue > 0)
        transform.eulerAngles = Vector2.zero;
        else if (moveInputValue < 0)
        transform.eulerAngles = Vector2.up * 180;
    }
}

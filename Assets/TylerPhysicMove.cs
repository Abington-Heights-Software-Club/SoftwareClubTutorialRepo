using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TylerPhysicMove : MonoBehaviour
{
    private Rigidbody2D rb;
    private float movement;
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        movement = 0;
    }

    // Update is called once per frame
    void Update()
    {
        movement = Input.GetAxisRaw("Horizontal");
    }

    private void FixedUpdate()
    {
        if (movement != 0)
        {
            rb.velocity = new Vector2(movement, rb.velocity.y);
        }
        else
        {
            rb.velocity = new Vector2(0, rb.velocity.y);
        }
    }
}

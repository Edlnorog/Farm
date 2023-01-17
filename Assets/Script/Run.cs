using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Run : MonoBehaviour
{
    public static float speed=1f;
    private float keyhor,keyver;
    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        keyhor = Input.GetAxis("Horizontal");
        
        rb.velocity = new Vector2(keyhor * speed, keyver * speed);



    }
}

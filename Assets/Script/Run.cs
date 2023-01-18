using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Run : MonoBehaviour
{
    public float speed=1f;
    private float keyhor, keyver;
    private Rigidbody2D rb;
    public Animator anim;
    private Vector2 direct;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    void FixedUpdate()
    {
        direct.x = Input.GetAxisRaw("Horizontal");
        direct.y = Input.GetAxisRaw("Vertical");
        rb.MovePosition(rb.position + direct * speed * Time.fixedDeltaTime);
        anim.SetFloat("Horizontal", direct.x);
        anim.SetFloat("Vertical", direct.y);
        anim.SetFloat("Speed", direct.sqrMagnitude);
        
    }
}

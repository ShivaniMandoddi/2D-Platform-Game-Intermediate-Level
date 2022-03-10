using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementScript : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D rb;
    SpriteRenderer render;
    public float playerSpeed;
    Animator animator;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        render = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float inputX = Input.GetAxis("Horizontal")*playerSpeed;
        rb.velocity = new Vector3(inputX, 0,0);
        if (inputX < 0)
            render.flipX = true;
        else
            render.flipX = false;
        animator.SetBool("IsWalk", inputX != 0);

    }
}

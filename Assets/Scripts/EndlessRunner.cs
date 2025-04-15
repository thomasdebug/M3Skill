using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndlessRunner : MonoBehaviour
{
    Animator animator;
    Vector3 velocity = Vector3.zero;
    Vector3 acceleration = Vector3.zero;
    float h0;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        h0 = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            print("jump");
            animator.Play("Jump");
            acceleration = new Vector3(0, -36, 0);
            velocity = new Vector3(0, 10, 0);
        }

        velocity += acceleration * Time.deltaTime;
        transform.position += velocity * Time.deltaTime;

        if (transform.position.y < h0)
        {
            acceleration = Vector3.zero;
            velocity = Vector3.zero;
            transform.position = new Vector3(transform.position.x, h0, 0);
        }


    }
}

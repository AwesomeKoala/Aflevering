using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    Rigidbody2D rb;
    public float bulletSpeed;
    float moveInput = 0;
    float life;



    // Start is called before the first frame update
    void Start()
    {
        life = Time.time + 1f;

        rb = GetComponent<Rigidbody2D>();
        moveInput = Input.GetAxis("Horizontal");

        if (moveInput >= 0)
        {
            rb.AddForce(Vector2.right * bulletSpeed, ForceMode2D.Impulse);
        }
        else
        {
            rb.AddForce(Vector2.left * bulletSpeed, ForceMode2D.Impulse);
        }
    }

    private void Update()
    {
        if(life <= Time.time)
        {
            Destroy(gameObject);
        }
    }

}


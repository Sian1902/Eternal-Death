using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class risingwater : MonoBehaviour
{
    [SerializeField] float speed = 0.5f;
    Rigidbody2D rgd;
    bool full=false;
    private void Start()
    {
        rgd= GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        if (!full)
        {
            rgd.velocity = new Vector2(rgd.velocity.x, speed);
        }
        else
        {
            rgd.velocity = new Vector2(0, 0);

        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("ceiling"))
        {
            full = true;
        }
    }
}

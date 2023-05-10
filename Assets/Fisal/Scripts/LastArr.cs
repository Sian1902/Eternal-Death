using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LastArr : MonoBehaviour
{
    [SerializeField] float speed=-7.7f;
    Rigidbody2D rb;
    public int ArrowEnabled = 0;
    public GameObject Player;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Player = GameObject.FindGameObjectWithTag("Player");
        
    }
    private void Update()
    {
        rb.velocity = new Vector2(speed * ArrowEnabled, 0);
    }

}

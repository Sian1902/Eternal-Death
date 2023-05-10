using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deadplayerrotation : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("area effector"))
        {
            gameObject.GetComponent<Rigidbody2D>().freezeRotation= true;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("ground"))
        {
            gameObject.GetComponent<Rigidbody2D>().freezeRotation = false;
        }
    }
}

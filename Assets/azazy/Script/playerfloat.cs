using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class playerfloat : MonoBehaviour
{
    [SerializeField] float Speed = 0.4f;
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Dead Player"))
        {
            gameObject.transform.SetParent(collision.transform);
            collision.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0, Speed);
        }
    }
    

}

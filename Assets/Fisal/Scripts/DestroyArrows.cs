using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyArrows : MonoBehaviour
{
    [SerializeField] GameObject waypoint;
    [SerializeField] GameObject deadbody;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Border")
        {
            Destroy(this.gameObject);
        }
        if (collision.CompareTag("Player"))
        {
            Destroy(this.gameObject);
            collision.gameObject.transform.position = new Vector3(-31.25f, 2.59f, -0.3894588f);
            Instantiate(deadbody, gameObject.transform.position, Quaternion.identity);

        }
    }
}

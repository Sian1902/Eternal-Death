using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyCollected : MonoBehaviour
{
    PolygonCollider2D keyCollider;
    GameObject key;

    private void Start()
    {
        keyCollider = GetComponent<PolygonCollider2D>();
        key = GetComponent<GameObject>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            gameObject.SetActive(false);
            keyCollider.enabled = false;
        }
    }

}

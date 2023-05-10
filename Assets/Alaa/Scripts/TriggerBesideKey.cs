using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TriggerBesideKey : MonoBehaviour
{
    [SerializeField] GameObject gameObject1;
    [SerializeField] GameObject wall;
    [SerializeField] BoxCollider2D boxCollider;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            gameObject.SetActive(false);
            gameObject1.SetActive(true);
            wall.SetActive(false);
            boxCollider.enabled= false;
        }
        
    }
}

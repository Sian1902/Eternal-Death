using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LastButton : MonoBehaviour
{
    [SerializeField] GameObject gameObject1;
    [SerializeField] GameObject gameObject2;
    [SerializeField] GameObject gameObject3;
    [SerializeField] GameObject gameObject4;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player") || collision.gameObject.CompareTag("Dead Player"))
        {
            gameObject.SetActive(false);
            gameObject1.SetActive(true);
            gameObject2.SetActive(true);
            gameObject3.SetActive(true);
            gameObject4.SetActive(true);

        }
    }
}

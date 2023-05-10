using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonUpAgain : MonoBehaviour
{
    [SerializeField] GameObject gameObject1;
    [SerializeField] GameObject gameObject2;
    [SerializeField] GameObject gameObject3;
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            gameObject.SetActive(false);
            gameObject1.SetActive(true);
            gameObject2.SetActive(false);
            gameObject3.SetActive(false);
        }

    }
}

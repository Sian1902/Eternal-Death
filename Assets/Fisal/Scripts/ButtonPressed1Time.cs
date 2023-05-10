using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPressed1Time : MonoBehaviour
{

    [SerializeField] GameObject Platform;
    [SerializeField] GameObject ButtonPressed;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player") || collision.gameObject.CompareTag("Dead Player")|| collision.gameObject.CompareTag("Box"))
        {
            gameObject.SetActive(false);
            Platform.SetActive(false);
            ButtonPressed.SetActive(true);
        }
    }
}

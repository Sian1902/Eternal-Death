using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class floatingBody : MonoBehaviour
{
    float timetorise = 4;
    bool floating = false;
  

    // Update is called once per frame
    void Update()
    {
        if(floating)
        timetorise -= Time.deltaTime;
        if (timetorise <= 0)
        {
            gameObject.GetComponent<Rigidbody2D>().mass= 1;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("water"))
        {
            floating= true;
        }
    }
}

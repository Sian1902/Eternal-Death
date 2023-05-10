using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowBehavior : MonoBehaviour
{
    [SerializeField] float timeDelay;
    [SerializeField] float speed;
    Rigidbody2D rb;
    Vector2 pos;
    private void Start()
    {
        StartCoroutine(Arrows());
        pos = transform.position;
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(rb.velocity.x, speed);
    }

    IEnumerator Arrows()
    {
        while (true)
        {
            GameObject ArrowInstantiate = Instantiate(gameObject, pos, Quaternion.identity);
            yield return new WaitForSeconds(timeDelay);
            Destroy(ArrowInstantiate, 5f);
        }
    }
}

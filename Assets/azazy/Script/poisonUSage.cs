using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class poisonUSage : MonoBehaviour
{
    int PoisonCNT=0;
    [SerializeField] GameObject deadplayer,RespawnPoint;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X) && PoisonCNT > 0)
        {
            Instantiate(deadplayer, gameObject.transform.position, Quaternion.identity);
            gameObject.transform.position = RespawnPoint.transform.position;
            PoisonCNT--;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("poison"))
        {
            PoisonCNT++;
            Destroy(collision.gameObject);
        }
    }
}

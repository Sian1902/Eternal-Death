using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchF : MonoBehaviour
{
   [SerializeField] List <PlatformMotionF> motion=new List<PlatformMotionF>() ;
   [SerializeField] GameObject Switched;
    SpriteRenderer spr;

    private void Start()
    {
        spr = GetComponent<SpriteRenderer>();
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            spr.color = new Color(0, 0, 0, 0);
            //gameObject.SetActive(false);
            Switched.SetActive(true);
            for(int i=0;i<motion.Count;i++)
            {
                
                motion[i].PlatformEnabled= 1;
            }
           
        }
    }
}

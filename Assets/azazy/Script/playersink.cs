using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playersink : MonoBehaviour
{
    public GameObject g1;
    public GameObject g2;
    public GameObject deadplayer;
    public GameObject RespawnPoint;
    public  float outofbreath = 20;
    [SerializeField] Movement move;
    [SerializeField] Text sinking;
    void Start()
    {
        sinking.text = "sinking : " + (int)outofbreath;
    }

    // Update is called once per frame
    void Update()
    {
        sinking.text = "sinking : " + (int)outofbreath;
        if (g1.transform.position.y >= g2.transform.position.y)
        {
            outofbreath-=Time.deltaTime;
        }
        else
        {
            outofbreath = 20;
        }
        if (outofbreath <= 0)
        {
            Instantiate(deadplayer, gameObject.transform.position, Quaternion.identity);
            move.lives--;
            gameObject.transform.position = RespawnPoint.transform.position;
            outofbreath = 20;
        }
    }
}

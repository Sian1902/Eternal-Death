using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ArrowSpawn : MonoBehaviour
{
    [SerializeField]
    Transform[] respawnpoints;
    [SerializeField] GameObject fallingarrow; 
    [SerializeField] float timeDestroy=4f;
    Vector2 pos;

    void Start()
    {
        ArrowsSpawn();
        StartCoroutine(Arrowspawning());
        pos = transform.position;
    }
    IEnumerator Arrowspawning()
    {
        while(true){

            yield return new WaitForSeconds(1);
            ArrowsSpawn();
        }
        
    }
    private void ArrowsSpawn()
    {

       Instantiate(fallingarrow, respawnpoints[Random.Range(0,4)].position,Quaternion.identity);
        Destroy(fallingarrow,timeDestroy);
    }
}

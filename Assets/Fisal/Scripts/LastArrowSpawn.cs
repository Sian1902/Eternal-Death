using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LastArrowSpawn : MonoBehaviour
{

    [SerializeField] List<LastArr> Arrows = new List<LastArr>();
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            for (int i = 0; i < Arrows.Count; i++)
            {

                Arrows[i].ArrowEnabled = 1;
            }
        }
    }
}

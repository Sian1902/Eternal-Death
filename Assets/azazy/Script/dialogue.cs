using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;

public class dialogue : MonoBehaviour
{
    public Text textcomponent;
    public string[] lines;
    public float textspeed;
    public GameObject player;
     float changetime = 2f,wait=0f;
  
    private int index;
    private int progress;
    public bool talking;
    // Start is called before the first frame update
    void Start()
    {
        progress = 0;
        talking = false;
        textcomponent.text=String.Empty;
        startdialogue();
     
    }

    // Update is called once per frame
    void Update()
    {
        if (index == 3)
        {
            wait = 7f;
            index++;
        }
        else if(index == 6) {
            wait = 5f;
            index++;
        }
        wait -= Time.deltaTime;
       changetime-=Time.deltaTime;
        if (wait <= 0)
        {
            

            if (changetime <= 0f)
            {
                talking = true;
                progress++;

                if (textcomponent.text == lines[index])
                {
                    nextline();
                }
                else
                {
                    StopAllCoroutines();
                    textcomponent.text = lines[index];
                }
                changetime = 2f;

            }
        }

        if (talking)
        {
            if ( String.IsNullOrEmpty(lines[index]))
            {
                talking = false;
                //  progress++;

            }
            if (Input.GetMouseButtonDown(0))
            {
                
                if (textcomponent.text == lines[index])
                {
                    nextline();
                }
                else
                {
                    StopAllCoroutines();
                    textcomponent.text = lines[index];
                }
            }
        }

    }
    

    void startdialogue()
    {
        index = 0;
        StartCoroutine(typeline());
    }

    IEnumerator typeline()
    {
        foreach (char c in lines[index].ToCharArray())
        {
            textcomponent.text += c;
            yield return new WaitForSeconds(textspeed);
        }
    }

    public void nextline()
    {
        if (index < lines.Length - 1)
        {
            index++;
            textcomponent.text=String.Empty;
            StartCoroutine(typeline());
        }
        else
        {
            gameObject.SetActive(false);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OneWayPlatform : MonoBehaviour
{
	PlatformEffector2D platEfector;
	float waitTime;
	private void Awake()
	{
		platEfector = GetComponent<PlatformEffector2D>();
	}
	private void Update()
	{
		if (Input.GetKeyUp(KeyCode.DownArrow))
		{
			waitTime = 0.5f;
		}
		if (Input.GetKey(KeyCode.DownArrow))
		{
			if(waitTime <= 0)
			{
                platEfector.rotationalOffset = 180;
				waitTime = 0.5f;
            }
			else
			{
				waitTime -= Time.deltaTime;
			}
		}
		if (Input.GetKey(KeyCode.Space))
		{
			platEfector.rotationalOffset = 0;
		}
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
	Animator animCamera;
	private void Start()
	{
		animCamera = GetComponent<Animator>();
	}
	public void Shack()
	{
		animCamera.SetTrigger("Shack");
	}
}

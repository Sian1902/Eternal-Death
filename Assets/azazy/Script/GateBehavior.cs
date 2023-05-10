using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateBehavior : MonoBehaviour
{
	[SerializeField] float speedGate;
    [SerializeField] public bool isGateOpen = false;
	[SerializeField] float diriction;
	[SerializeField] bool deadBodyOnGate;
	[SerializeField] float amountMove;
	[SerializeField] bool xAixis;
	Vector3 openGatePosition;
	Vector3 closeGatePosition;
	private void Awake()
	{
		closeGatePosition = transform.position;
		if (xAixis)
		{
            openGatePosition = new Vector3(transform.position.x - Mathf.Sign(diriction) * amountMove, transform.position.y , transform.position.z);
        }
		else
		{
            openGatePosition = new Vector3(transform.position.x, transform.position.y + Mathf.Sign(diriction) * amountMove, transform.position.z);
        }
    }
	private void Update()
	{
		if (isGateOpen && !deadBodyOnGate)
		{
			OpenGate();
		}
		else
		{
			CloseGate();
		}
	}
	void OpenGate()
	{
		if(transform.position != openGatePosition)
		{
			transform.position = Vector3.MoveTowards(transform.position, openGatePosition, speedGate * Time.deltaTime);
		}
	}
	void CloseGate()
	{
        if (transform.position != closeGatePosition)
        {
            transform.position = Vector3.MoveTowards(transform.position, closeGatePosition, speedGate * Time.deltaTime);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Dead Player"))
        {
            deadBodyOnGate = true;
        }
    }
	private void OnTriggerExit2D(Collider2D collision)
	{
        if (collision.gameObject.CompareTag("Dead Player"))
        {
            deadBodyOnGate = false;
        }
    }
}

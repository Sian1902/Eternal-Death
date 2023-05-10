using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fakebutton : MonoBehaviour
{
    [SerializeField] float speedButton;
    [SerializeField] bool isButtonPressed = false;
    [SerializeField] bool onePressedButton;
    Vector3 pressedButtonPosition;
    Vector3 notPressedButtonPosition;
    [SerializeField] List<GateBehavior> gate = new List<GateBehavior>();
    [SerializeField] float numDeadBody = 2;
    [SerializeField] bool deadplayeron;
    private void Awake()
    {
        notPressedButtonPosition = transform.position;
        pressedButtonPosition = new Vector3(transform.position.x, transform.position.y - 0.5f, transform.position.z);
    }
    private void Update()
    {
        if (isButtonPressed)
        {
            ButtonPressed();
        }
        else
        {
            ButoonNotPressed();
        }
    }
    void ButtonPressed()
    {
        if (transform.position != pressedButtonPosition)
        {
            transform.position = Vector3.MoveTowards(transform.position, pressedButtonPosition, speedButton * Time.deltaTime);
        }
    }
    void ButoonNotPressed()
    {
        if (transform.position != notPressedButtonPosition)
        {
            transform.position = Vector3.MoveTowards(transform.position, notPressedButtonPosition, speedButton * Time.deltaTime);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            ButtonPressedON();

        }
        if (collision.gameObject.CompareTag("hinge"))
        {
            ButtonPressedON();

        }
        

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player") && !onePressedButton && !deadplayeron || collision.gameObject.CompareTag("hinge") )
        {
            isButtonPressed = false;
            for (int i = 0; i < gate.Count; i++)
            {
                gate[i].isGateOpen = false;
            }
            numDeadBody++;
        }

    }
    void ButtonPressedON()
    {
        isButtonPressed = true;
        for (int i = 0; i < gate.Count; i++)
        {
            gate[i].isGateOpen = true;
        }
        numDeadBody--;
    }
}

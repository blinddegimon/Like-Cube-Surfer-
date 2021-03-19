using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Move_1: MonoBehaviour
{

    public float forwardSpeed;

    public int coinCounter;
    public Text coinText;

    private Touch touch;

    private float speedMul = 0.02f;

    private float xPos;
    private float yPos;
    private float zPos;

    private void Start()
    {
        coinCounter = 0;
    }

    private void FixedUpdate()
    {

        xPos = 0;

        if (Input.touchCount > 0)
        {

            touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Moved)
            {
                xPos = touch.deltaPosition.x * speedMul;                           
            }

        }
        
        yPos = transform.position.y;
        zPos = forwardSpeed * Time.deltaTime;
        
        if ((int)transform.rotation.eulerAngles.y == 0)
        {
            zPos += transform.position.z;
            xPos += transform.position.x;          
            transform.position = new Vector3(xPos, yPos, zPos);           
        }
        else if ((int)transform.rotation.eulerAngles.y == 90)
        {
            xPos *= -1;
            xPos += transform.position.z;
            zPos += transform.position.x;
            transform.position = new Vector3(zPos, yPos, xPos);
        }
        else if ((int)transform.rotation.eulerAngles.y == 180)
        {
            zPos *= -1;
            xPos *= -1;
            zPos += transform.position.z;
            xPos += transform.position.x;
            transform.position = new Vector3(xPos, yPos, zPos);
        }
        else if ((int)transform.rotation.eulerAngles.y == 270)
        {
            zPos *= -1;
            xPos += transform.position.z;
            zPos += transform.position.x;
            transform.position = new Vector3(zPos, yPos, xPos);
        }

    }

    public void updateCoinCounter() 
    {
        coinCounter += 1;
        coinText.text = coinCounter.ToString();
    }
 
}

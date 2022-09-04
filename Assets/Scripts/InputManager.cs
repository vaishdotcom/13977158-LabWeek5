using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    private Transform[] transArray;
    private GameObject redObj;
    private GameObject blueObj;
    private float yPosition;
  
    // Start is called before the first frame update
    void Start()
    {
        redObj = GameObject.FindWithTag("Red");
        blueObj = GameObject.FindWithTag("Blue");

        transArray = new Transform[2];

        transArray[0] = redObj.transform;
        transArray[1] = blueObj.transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("w"))
        {
           transArray[0].transform.Rotate(0.0f, 0.0f, 45.0f, Space.Self);
           transArray[1].transform.Rotate(0.0f, 0.0f, -45.0f, Space.Self);
        }

        if (Input.GetButtonDown("Fire1"))
        {
            Vector3 redPos = transArray[0].transform.position;
            Vector3 bluePos = transArray[1].transform.position;
            Vector3 tempPos;

            tempPos.y = redPos.y;
            redPos.y = bluePos.y;
            bluePos.y = tempPos.y;

            transArray[0].transform.position = redPos;
            transArray[1].transform.position = bluePos;
        }
    }
}

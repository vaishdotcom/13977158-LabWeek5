using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    private Transform[] transArray;
    private GameObject redObj;
    private GameObject blueObj;
  
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
        
    }
}

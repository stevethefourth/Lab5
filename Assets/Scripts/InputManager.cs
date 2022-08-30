using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    private Transform[] transArray;
    // Start is called before the first frame update
    void Start()
    {
        transArray = new Transform[2];
        transArray[0] = GameObject.FindWithTag("Red").transform;
        transArray[1] = GameObject.FindWithTag("Blue").transform;
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetKeyDown(KeyCode.W))
        {
            transArray[0].transform.Rotate(0.0f, 0.0f, 45.0f);
            transArray[1].transform.Rotate(0.0f, 0.0f, -45.0f);
        }

        if(Input.GetButtonDown("Fire1"))
        {
            Vector3 YRed = transArray[0].position;
            Vector3 YBlue = transArray[1].position;
            Vector3 Temp = YRed;
            YRed.y = YBlue.y;
            YBlue.y = Temp.y;
            transArray[0].position = YRed;
            transArray[1].position = YBlue;

        }
    }
}

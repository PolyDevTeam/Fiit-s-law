using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class touch : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        Debug.Log("Test DEBUG");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            foreach (Touch touch in Input.touches)
            {
                Debug.Log("touch on : " + touch.position);
            }
        }

        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("click on : " + Input.mousePosition);
        }

    }
}

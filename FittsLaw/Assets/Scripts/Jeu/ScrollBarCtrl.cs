using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScrollBarCtrl : MonoBehaviour {

	// Use this for initialization
	void Start () {
        //  The scrollbar begin on middle
        gameObject.GetComponent<Scrollbar>().value = 0.5f;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    /**
     * #Brief : Change the value of the scrollbar with the dynamic vector2 give by the scroll rect
     * #args : Vector2 val -> Dynamic vector2 give by the scroll rect
     */
    public void ChangeValue (Vector2 val)
    {
        gameObject.GetComponent<Scrollbar>().value = val.x;
    }
}

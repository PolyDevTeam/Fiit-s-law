using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelMissAutoResize : MonoBehaviour {

    public GameObject target;
    // Use this for initialization

    void Start () {

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    /**
     * #Brief : auto resize the gameobject with this script to 2.5*size of the GameObject target and move the panel to the target position
     * 
     * #args : float d -> the distance of the game zone
     */
    public void Resize(float d)
    {
        RectTransform rect = GetComponent<RectTransform>();
        RectTransform rect_target = target.GetComponent<RectTransform>();

        Vector2 size_target = rect_target.sizeDelta;

        // width
        rect.sizeDelta = new Vector2(d, rect.sizeDelta.y);


    }
}

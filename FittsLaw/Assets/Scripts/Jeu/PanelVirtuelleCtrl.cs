using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelVirtuelleCtrl : MonoBehaviour {

    // Use this for initialization
    /**
     * #Brief : Init the Panel Virtuelle to distances parametrize in experience + 1/3 each side
     */
    void Start () {
        Experience exp = Experience.control;
        Vector2 v = gameObject.GetComponent<RectTransform>().sizeDelta;
        v.x = exp.l_distance[exp.essaiAct] + 2*((1f / 3f) * exp.l_distance[exp.essaiAct]);
        gameObject.GetComponent<RectTransform>().sizeDelta = v;

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}

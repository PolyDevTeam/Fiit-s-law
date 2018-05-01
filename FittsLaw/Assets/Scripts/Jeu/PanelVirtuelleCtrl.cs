using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelVirtuelleCtrl : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Experience exp = Experience.control;
        Vector2 v = gameObject.GetComponent<RectTransform>().sizeDelta;
        v.x = exp.l_distance[0] + 2*((1f / 3f) * exp.l_distance[0]);
        gameObject.GetComponent<RectTransform>().sizeDelta = v;

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}

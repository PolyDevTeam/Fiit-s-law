using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelMissAutoResize : MonoBehaviour {

    public GameObject target;

    // Use this for initialization
    void Start () {
        RectTransform rect = GetComponent<RectTransform>();
        RectTransform rect_target = target.GetComponent<RectTransform>();

        Vector2 size_target = rect_target.sizeDelta;

        rect.sizeDelta = size_target;
        rect.transform.localScale = new Vector3(2.5f, 2.5f, 1f);

        Vector3 position_target = rect_target.position;

        rect.position = position_target;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResizePanel : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}

    /**
     * #Brief : Resise the content Content panel when adding new PanelEssai
     * #args : float y -> the size to add or remove of the COntent panel
     */
    public void Resize(float y)
    {
        RectTransform r = gameObject.GetComponent<RectTransform>();

        Vector2 temp = new Vector2(0, y);
        r.sizeDelta += temp;
    }
}

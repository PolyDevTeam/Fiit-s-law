using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class removeClick : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Remove()
    {
        GameObject.Destroy(GameObject.Find("PanelEssai(Clone)"+ClonePanel.nbPanel));
        if (ClonePanel.nbPanel > 1)
        {
            ClonePanel.nbPanel--;
        } 
    }


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModalCtrl : MonoBehaviour {

	// Use this for initialization
	void Start () {
        gameObject.SetActive(false);
	}
	
    public void Activation()
    {
        gameObject.SetActive(true);
    }

	// Update is called once per frame
	void Update () {
		
	}
}

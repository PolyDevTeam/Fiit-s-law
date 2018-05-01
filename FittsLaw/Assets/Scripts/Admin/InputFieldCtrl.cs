using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputFieldCtrl : MonoBehaviour {

    Experience exp;
	// Use this for initialization
	void Start () {
        exp = Experience.control;
	}


    /**
     * #Brief : Save the number of Aller-Retour to the experience consistant object with list.
     */
    public void ClearAndSave()
    {
        exp.nAllerRetour = int.Parse(gameObject.GetComponent<InputField>().text);
    }
}

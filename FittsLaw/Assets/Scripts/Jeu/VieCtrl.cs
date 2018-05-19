using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VieCtrl : MonoBehaviour {

    Experience exp;
    public int pv;
    Text t_vie;

    // Use this for initialization
    void Start () {
        exp = Experience.control;
        pv = exp.nAllerRetour*10/100;
        t_vie = gameObject.GetComponent<Text>();
        t_vie.text = pv.ToString();
	}

    public void SetPv ()
    {
        pv -= 1;
        t_vie.text = pv.ToString();
    }


}

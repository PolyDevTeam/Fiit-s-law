using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ParamController : MonoBehaviour {

    public static bool is_parametrize = false;
    Vector3 zero = new Vector3(0, 0, 0);
    Vector3 un = new Vector3(1, 1, 1);

    //  variable for timer
    float begin_time,
        current_time,
        wait_time = 3;


    GameObject TextParam;
    GameObject PlayButton;
	// Use this for initialization
	void Start () {
        TextParam = GameObject.Find("TextParam");
        PlayButton = GameObject.Find("ButtonJeu");
        //Debug.Log(is_active);
        if (is_parametrize)
        {
            TextParam.GetComponent<RectTransform>().localScale = un;
            PlayButton.GetComponent<Button>().interactable = true;
        }
        else
        {
            TextParam.GetComponent<RectTransform>().localScale = zero;
        }
        begin_time = Time.time;
    }
	
	// Update is called once per frame
	void Update () {
        float current_time = Time.time;
        if (is_parametrize)
        {
            if (current_time - begin_time > wait_time)
            {
                TextParam.GetComponent<RectTransform>().localScale = zero;
                is_parametrize = false;
            }
        }
    }
}

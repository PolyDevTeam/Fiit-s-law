﻿using System.Collections;
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
    GameObject ResultButton;

    // Use this for initialization
    /**
     * #Brief : if the player parametrize the game in param scene we show a message and activate the game Button
     */
    void Start () {
        TextParam = GameObject.Find("TextParam");
        PlayButton = GameObject.Find("ButtonJeu");
        ResultButton = GameObject.Find("ButtonResultat");

        //Debug.Log(is_active);
        if (is_parametrize)
        {
            TextParam.GetComponent<RectTransform>().localScale = un;
            PlayButton.GetComponent<Button>().interactable = true;
            ResultButton.GetComponent<Button>().interactable = true;
        }
        else
        {
            TextParam.GetComponent<RectTransform>().localScale = zero;
        }
        begin_time = Time.time;
    }

    // Update is called once per frame
    /**
     * #Brief : Just count float wait_time to make the message disappear
     */
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

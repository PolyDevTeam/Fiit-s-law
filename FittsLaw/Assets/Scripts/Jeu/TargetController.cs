﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TargetController : MonoBehaviour {

    public static bool is_active_R = true;
    public static bool is_active_L = true;

    GameObject Panel_MR;
    GameObject Panel_ML;
    GameObject Target_L;
    GameObject Target_R;

    AudioSource Hit;
    AudioSource Miss;

    Experience exp;
    static float nbClick;
    GameObject timer;



    // Use this for initialization
    /**
     * #Brief : Init the Targets, the MissPanels, the audio, and place the target at the needed distance and resize the miss panel to the target
     */
    void Start()
    {
        //GameObject.Find("PanelNext").SetActive(false);
        Panel_MR = GameObject.Find("PanelMissRight");
        Panel_ML = GameObject.Find("PanelMissLeft");
        Target_R = GameObject.Find("TargetRight");
        Target_L = GameObject.Find("TargetLeft");



        Hit = GameObject.Find("AudioHit").GetComponent<AudioSource>();
        Miss = GameObject.Find("AudioMiss").GetComponent<AudioSource>();

        exp = Experience.control;
        timer = GameObject.Find("Temp");


        float distance = exp.l_distance[0];
        nbClick = exp.nAllerRetour*2 + 1;
        //Debug.Log("distance =" + distance);

        //  Place the target and resize the panelMiss
        Target_R.transform.position = new Vector3(distance / 2, 0);
        Target_L.transform.position = new Vector3(-distance / 2, 0);

        Panel_ML.GetComponent<PanelMissAutoResize>().resize();
        Panel_MR.GetComponent<PanelMissAutoResize>().resize();


        
    }

    /**
     * #Brief : if you click on target desactive his side and activate the other
     * #args : string color -> the color is the color to apply to the target and indicate if hit -> green if miss -> red
     */
    public void Click(string color)
    {

        //  Right CTRL
        if (name.Contains("Right"))
        {
            if (is_active_R)
            {
                ChangeColor.SetColor(color, Target_R);
                Hit_or_miss(color);

                //  desactive right
                Panel_MR.SetActive(false);
                is_active_R = false;


                //  active left
                Panel_ML.SetActive(true);
                is_active_L = true;

                nbClick--;
            }

        }

        //  Left CTRL
        if (name.Contains("Left"))
        {
            if (is_active_L)
            {
                ChangeColor.SetColor(color, Target_L);
                Hit_or_miss(color);

                //  desactive left
                Panel_ML.SetActive(false);
                is_active_L = false;



                //  active right
                Panel_MR.SetActive(true);
                is_active_R = true;

                nbClick--;
            }

        }


        //  Active the Timer when first click
        if (timer.GetComponent<TimerCtrl>().startT == false)
        {
            timer.GetComponent<TimerCtrl>().StartTimer();
        }

        //  Desactive the timer if click count < Experience.nbAllerRetour
        if (nbClick == 0)
        {
            timer.GetComponent<TimerCtrl>().StopTimerAndSave();
            Debug.Log("testc");
            //GameObject.Find("PanelNext").SetActive(true);
        }


    }



    /**
     * #Brief : play some jingle or animation depend on color if hit or miss
     * #args : string color -> indicate if hit->green or miss->red
     */
    void Hit_or_miss(string color)
    {
        //  Play Sound His or Miss
        switch (color)
        {
            case "vert":
                Hit.Play();
                break;
            case "rouge":
                Miss.Play();
                break;
        }
    }



    //  Method for Drag
    public bool is_drag = false;

    
    public void Down()
    {
        is_drag = true;
    }

    public void Up()
    {
        is_drag = false;
    }

    public void Exit()
    {
        if (is_drag)
        {
            Click("rouge");
        }
    }
    // Update is called once per frame
    void Update () {
		
	}
}

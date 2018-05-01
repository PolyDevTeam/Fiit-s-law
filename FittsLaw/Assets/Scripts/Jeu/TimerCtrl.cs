using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerCtrl : MonoBehaviour {

    Text t_timer;
    public bool startT = false;

    //  variable for timer
    float begin_time, current_time;

    Experience exp;

    // Use this for initialization
    void Start()
    {
        t_timer = GameObject.Find("Temp").GetComponent<Text>();
        t_timer.text = "0";
        exp = Experience.control;
    }

    public void StartTimer()
    {
        begin_time = Time.time;
        startT = true;
    }

    public void StopTimerAndSave()
    {
        startT = false;
        exp.l_temps.Add(current_time - begin_time);
    }

    // Update is called once per frame
    void Update()
    {
        if (startT == true)
        {
            float current_time = Time.time;
            t_timer.text = (current_time - begin_time).ToString("#.000");
        }

    }
}

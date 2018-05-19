using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerCtrl : MonoBehaviour {

    Text t_timer;
    public bool startT = false;

    //  variable for timer
    float begin_time, current_time;
    float just_time;

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

        exp.l_temps.Add(just_time);
        for (int i = 0; i < exp.l_temps.Count; i++)
        {
            Debug.Log("I = " + exp.l_temps.Count + " " + exp.l_temps[i]);
        }
    }

    public void StopTimer()
    {
        startT = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (startT == true)
        {
            float current_time = Time.time;
            just_time = (current_time - begin_time);
            t_timer.text = just_time.ToString("#.000");
        }

    }
}

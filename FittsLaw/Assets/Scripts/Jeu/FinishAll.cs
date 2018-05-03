using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FinishAll : MonoBehaviour {

    Experience exp;

    public void Finish()
    {
        exp = Experience.control;
        string str = gameObject.GetComponentsInChildren<InputField>()[0].text;

        Debug.Log(str);
        exp.d_time.Add(str, new List<float>(exp.l_temps));
        //Debug.Log(exp.d_time);
        SceneManager.LoadScene(0);
        exp.essaiAct = 0;
        exp.l_temps.Clear();
    }
}

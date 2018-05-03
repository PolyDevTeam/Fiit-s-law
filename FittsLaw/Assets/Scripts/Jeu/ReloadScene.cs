using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ReloadScene : MonoBehaviour {


    Experience exp;
    GameObject PopUpName;
    // Use this for initialization
	void Start () {
        exp = Experience.control;
        Debug.Log("EssaiAct = " + exp.essaiAct);
        Debug.Log("Distance = " + exp.l_distance[exp.essaiAct]);
        PopUpName = GameObject.Find("PanelName");
        PopUpName.SetActive(false);

    }

    public void Reload()
    {
        exp.essaiAct++;
        if (exp.essaiAct < exp.nEssais)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            //Debug.Log(exp.l_temps.Count);
        }
        else
        {
            PopUpName.SetActive(true);
            float distance = exp.l_distance[exp.essaiAct-1];
            PopUpName.GetComponent<RectTransform>().sizeDelta = new Vector2(distance + 2 * (1f / 3f * distance), 1280);
            PopUpName.GetComponent<RectTransform>().position = new Vector3(0, 0);

            //PopUpName.GetComponent<FinishAll>().Finish();
            //Application.Quit();
        }
    }

}

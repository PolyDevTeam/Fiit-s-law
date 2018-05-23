using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelResultatCtrl : MonoBehaviour {


    Experience exp;
    public Stack<GameObject> s_panel;
    GameObject ContentPanel;
    

	// Use this for initialization
	void Start () {
        exp = Experience.control;
        exp.Calcul();

        s_panel = new Stack<GameObject>();
        GameObject panel1 = GameObject.Find("PanelResultat");
        panel1.GetComponentsInChildren<Text>()[0].text = "D1 = " + exp.l_distance[0];
        panel1.GetComponentsInChildren<Text>()[1].text = "mean = " + exp.l_mean[0];


        s_panel.Push(panel1);

        ContentPanel = GameObject.Find("Content");
        
        for (int i = 1; i < exp.l_distance.Count; i++)
        {
            Clone(panel1);
        }

    }

    public void Clone(GameObject src)
    {
        //  Clone the first panel and add the clone to the stack
        GameObject clone = Instantiate(src, src.transform.parent);
        s_panel.Push(clone);
        clone.name += s_panel.Count;
        clone.GetComponentsInChildren<Text>()[0].text = "D" + (s_panel.Count) + " = " + exp.l_distance[s_panel.Count-1];
        clone.GetComponentsInChildren<Text>()[1].text = "mean = " + exp.l_mean[s_panel.Count-1];


        Debug.Log("size = " + s_panel.Count);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}

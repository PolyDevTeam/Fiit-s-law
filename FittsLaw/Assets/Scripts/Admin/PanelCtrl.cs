using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelCtrl : MonoBehaviour
{

    public Stack<GameObject> s_Panel;
    ScrollRect scrollRect;
    GameObject ContentPanel;

    //  For save Distance data in for expérience
    Experience exp;

    // Use this for initialization
    void Start()
    {
        s_Panel = new Stack<GameObject>();
        GameObject panel1 = GameObject.Find("PanelEssai");
        panel1.GetComponentsInChildren<Text>()[0].text = "D0";

        s_Panel.Push(panel1);
        scrollRect = GameObject.Find("Scroll View").GetComponent<ScrollRect>();

        ContentPanel = GameObject.Find("Content");

        exp = Experience.control;
    }

    /**
     * #Brief : Clone the GameObject src(panelEssai) and add it to the stack of panel
     * #args : GameObject src -> the GameObject to clone, we need to clone the panelEssai
     */
    public void Clone(GameObject src)
    {
        //  Clone the first panel and add the clone to the stack
        GameObject clone = Instantiate(src, src.transform.parent);
        s_Panel.Push(clone);
        clone.name += s_Panel.Count;
        clone.GetComponentsInChildren<Text>()[0].text = "D" + (s_Panel.Count - 1);
        clone.GetComponentInChildren<InputField>().text = "";


        Debug.Log("size = " + s_Panel.Count);

        //  Scroll to the down
        scrollRect.velocity = new Vector2(0f, 1000f);

        ResizePanel.Resize(ContentPanel, 250);

    }

    /**
     * #Brief : Remove the last panel in the stack and destroy it
     */
    public void RemoveOne()
    {
        if (s_Panel.Count > 1)
        {
            Destroy(s_Panel.Pop());
            ResizePanel.Resize(ContentPanel, -250);

        }
    }

    /**
     * #Brief : Save all the distance to the experience consistant object with list.
     */
    public void ClearAndSave()
    {
        //  Getr the distance in all the clones panels
        List<float> temp = new List<float>();
        foreach (GameObject item in s_Panel)
        {
            float d = float.Parse(item.GetComponentInChildren<InputField>().text);
            temp.Add(d);
        }
        s_Panel.Clear();

        //  Cause the stack is lifo
        temp.Reverse();

        //  save in experience
        exp.l_distance = new List<float>(temp);
        exp.nEssais = exp.l_distance.Count;
    }

}

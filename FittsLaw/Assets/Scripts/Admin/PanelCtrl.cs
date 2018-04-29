using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelCtrl : MonoBehaviour
{

    public Stack<GameObject> s_Panel;
    ScrollRect scrollRect;

    //  For save Distance data in for expérience
    Experience exp;

    // Use this for initialization
    void Start()
    {
        s_Panel = new Stack<GameObject>();
        s_Panel.Push(GameObject.Find("PanelEssai"));
        scrollRect = GameObject.Find("Scroll View").GetComponent<ScrollRect>();

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
        Debug.Log("size = " + s_Panel.Count);

        //  Scroll to the down
        scrollRect.velocity = new Vector2(0f, 1000f);

    }

    /**
     * #Brief : Remove the last panel in the stack and destroy it
     */
    public void RemoveOne()
    {
        if (s_Panel.Count > 1)
        {
            Destroy(s_Panel.Pop());

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

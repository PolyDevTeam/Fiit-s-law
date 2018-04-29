using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClonePanel : MonoBehaviour {

    public static int nbPanel = 1;

    // Use this for initialization
    void Start()
    {
        Debug.Log("New Panel" + nbPanel);
        Text t = gameObject.GetComponentsInChildren<Text>()[0];
        t.text = "D" + nbPanel;
    }

    public void Clone(GameObject parent)
    {
        nbPanel++;
        GameObject clone = Instantiate(gameObject, parent.transform);
        clone.name += nbPanel;
        ScrollRect scrollRect = GameObject.Find("Scroll View").GetComponent<ScrollRect>();
        scrollRect.velocity = new Vector2(0f, 1000f);

    }

}

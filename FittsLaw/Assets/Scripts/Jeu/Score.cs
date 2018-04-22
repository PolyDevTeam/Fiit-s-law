using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    Text t_score;
    int score;

	// Use this for initialization
	void Start () {
        t_score = GameObject.Find("score").GetComponent<Text>();
        t_score.text = "0";
        score = 0;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0) || Input.touchCount > 1)
        {
            score++;
            t_score.text = score.ToString();
        }
    }
}

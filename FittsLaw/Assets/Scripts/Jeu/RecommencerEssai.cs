using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RecommencerEssai : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
    public void Recommencer()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}

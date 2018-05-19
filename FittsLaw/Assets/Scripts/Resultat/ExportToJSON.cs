using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class ExportToJSON : MonoBehaviour {


    Experience exp;

	// Use this for initialization
	void Start () {
        exp = Experience.control;
		
	}
	
    public void Export ()
    {
        Debug.Log(exp.ToJson());
        Debug.Log(Application.dataPath);
        File.WriteAllText(Application.dataPath + "/Resultats/experience.json", exp.ToJson());
    }

}

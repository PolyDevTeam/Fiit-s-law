using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class ExportToCsv : MonoBehaviour {

    Experience exp;

    // Use this for initialization
    void Start()
    {
        exp = Experience.control;

    }

    public void Export()
    {
        Debug.Log(exp.ToCsv());
        Debug.Log(Application.dataPath);
        File.WriteAllText(Application.dataPath + "/Resultats/experience.csv", exp.ToCsv());
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ValideSettings : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        //Distance = GameObject.Find("InputFieldDistance").GetComponent<InputField>();
        //Essais = GameObject.Find("InputFieldEssais").GetComponent<InputField>();
    }

    // Update is called once per frame
    void Update()
    {

    }



    public void Validation()
    {
        SceneManager.LoadScene(0);
        ParamController.is_parametrize = true;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ValideSettings : MonoBehaviour
{

    public void Validation()
    {
        SceneManager.LoadScene(0);
        ParamController.is_parametrize = true;
    }
}

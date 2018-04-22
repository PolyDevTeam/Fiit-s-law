using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BouttonMenu : MonoBehaviour
{

    public void ChangeScene(int scene)
    {
        //Debug.Log(PlayerPrefs.GetFloat("Dmax") + " " + PlayerPrefs.GetFloat("Nbessais"));
        SceneManager.LoadScene(scene);
    }
}

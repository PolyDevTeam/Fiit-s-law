using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BouttonMenu : MonoBehaviour
{
    /**
     * #Brief : switch to the scene in args
     * #args : int scene -> the scene to switch
     */
    public void ChangeScene(int scene)
    {
        //Debug.Log(PlayerPrefs.GetFloat("Dmax") + " " + PlayerPrefs.GetFloat("Nbessais"));
        SceneManager.LoadScene(scene);
    }
}

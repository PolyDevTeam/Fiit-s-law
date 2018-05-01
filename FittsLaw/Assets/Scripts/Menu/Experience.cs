﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Experience : MonoBehaviour
{

    public static Experience control;


    /** Attributs for the expérience
     * 
     * Number of essai
     * Number of Aller-Retour
     * List of distances
     * Dictionnary for (Name of subject, List of time)
     *
    **/

    public int nEssais;
    public int nAllerRetour;
    public List<float> l_distance;
    public Dictionary<string, List<float>> d_time;



    void Awake()
    {
        if (control == null)
        {
            DontDestroyOnLoad(gameObject);
            control = this;
        }

        else if (control != this)
        {
            Destroy(gameObject);
            Debug.Log(l_distance);
        }

    }


}

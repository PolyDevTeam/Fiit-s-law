using System.Collections;
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
     * Id Essai actuelle
     * List des temps de l'utilisateur actuelle
    **/

    public int nEssais;
    public int nAllerRetour;
    public List<float> l_distance;
    public Dictionary<string, List<float>> d_time;

    public int essaiAct = 0;
    public List<float> l_temps;

    /**
     * #Brief : Singleton when game start create an consistant instance of this object
     */
    void Awake()
    {
        if (control == null)
        {
            DontDestroyOnLoad(gameObject);
            control = this;
            l_temps = new List<float>();
            d_time = new Dictionary<string, List<float>>();
            l_distance = new List<float>();
        }

        else if (control != this)
        {
            Destroy(gameObject);
        }

    }


    /**
     * #Brief : Parse the Experience object to JSON format to put in JSON FILE
     */
    public string ToJson()
    {
        string json = "";

        //  Debut du JSON
        json += "{" + "\n";

        //  Objet Expérience
        json += "\"Experience\"" + ": " + "{" + "\n";

        //  Nombre Essais
        json += "\"NombreEssais\"" + ": " + nEssais + "," + "\n";

        //  NombreAllerRetour
        json += "\"NombreAllerRetour\"" + ": " + nAllerRetour + "," + "\n";

        //  ListeDistances
        json += "\"ListeDistance\"" + ": " + "[";
        foreach (float t in l_distance)
        {
            json += t + ", ";
        }
        json = json.Remove(json.Length - 2);
        json += "]" + "," + "\n";

        //  Dictionnaire <Nom, ListeTemps>
        /**
         *  Objet Nom0
         *      [T0, T1, T2, ...]
         *  Object Nom1
         *      [T0, T1, T2, ...]
         */

        json += "\"Dictionnaire\"" + ": " + "{" + "\n";
        foreach(KeyValuePair<string, List<float>> item in d_time)
        {
            json += "\"" + item.Key + "\"" + ": " + "[";
            foreach(float time in item.Value)
            {
                json += time + ", ";
            }
            json = json.Remove(json.Length - 2);
            json += "]" + "," + "\n";
        }
        json = json.Remove(json.Length - 2);
        json += "\n";
        json += "}" + "\n";

        //  Fin Experience objet
        json += "}" + "\n";


        //  Fin du JSON
        json += "}";

        return json;
    }

    /**
    * #Brief : Parse the Experience object to CSV format to put in CSV EXCEL FILE
    */
    public string ToCsv()
    {
        string csv = "";


        //  Objet Expérience
        csv += "\"Experience\"" + "\n";

        //  Nombre Essais
        csv += "\"NombreEssais\"" + ";" + nEssais + "\n";

        //  NombreAllerRetour
        csv += "\"NombreAllerRetour\"" + ";" + nAllerRetour + "\n";

        //  ListeDistances
        csv += "\"ListeDistance\"";
        foreach (float t in l_distance)
        {
            csv += ";" + t;
        }
        csv += "\n";

        //  Dictionnaire <Nom, ListeTemps>
        /**
         *  Objet Nom0
         *      [T0, T1, T2, ...]
         *  Object Nom1
         *      [T0, T1, T2, ...]
         */

        csv += "\"Dictionnaire\"" + "\n";
        foreach (KeyValuePair<string, List<float>> item in d_time)
        {
            csv += "\"" + item.Key + "\"";
            foreach (float time in item.Value)
            {
                csv += ";" + time;
            }
            csv += "\n";
        }
        csv += "\n";

        //  Fin du CSV

        return csv;
    }

}

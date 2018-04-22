using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeColor : MonoBehaviour {



    public static void SetColor(string color, GameObject obj)
    {
        Image img = obj.GetComponent<Image>();
        switch (color)
        {
            case "vert":
                img.color = new Color(0f, 1f, 0f);
                break;

            case "rouge":
                img.color = new Color(1f, 0f, 0f);
                break;

            case "bleu":
                img.color = new Color(0f, 0f, 1f);
                break;

            case "blanc":
                img.color = new Color(1f, 1f, 1f);
                break;

            case "noir":
                img.color = new Color(0f, 0f, 0f);
                break;

            default:
                Debug.Log("Couleur " + color + " Invalide");
                break;
        }

    }


}

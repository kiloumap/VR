using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour {

    public int compteur = 0;
   

    // Use this for initialization
    void Start () {
        TextMesh t = (TextMesh)gameObject.GetComponent(typeof(TextMesh));
        t.text = "0";
    }


	// Add point to score
    public void AddPoint(int time)
    {
        TextMesh t = (TextMesh)gameObject.GetComponent(typeof(TextMesh));
        compteur += time;
        t.text = compteur.ToString();
    }
}

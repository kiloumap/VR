using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TimerController : MonoBehaviour {
    public float timeLeft;
    // Use this for initialization
    void Start () {
        TextMesh timer = (TextMesh)gameObject.GetComponent(typeof(TextMesh));
        timeLeft = 30;
        timer.text = timeLeft.ToString("0");
    }
	
	// Update is called once per frame
	void Update ()
    {
        TextMesh timer = (TextMesh)gameObject.GetComponent(typeof(TextMesh));
        timeLeft -= Time.deltaTime;

        if(timeLeft > 0)
            timer.text = timeLeft.ToString("0");

        if (timeLeft < 0)
            SceneManager.LoadScene("menu_HelloVr");

        
    }
}

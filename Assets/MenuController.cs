using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour {
    public void StartGameInScene()
    {
        SceneManager.LoadScene("HelloVR");
    }

    public void EndOfGame()
    {
       
       
    }
}

    
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour {

    public void LoadScenes(string scenename)
    {
        SceneManager.LoadScene(scenename);

        if(scenename == "Quit")
        {
            Application.Quit();
        }

    }

}

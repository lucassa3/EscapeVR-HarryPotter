using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadscene : MonoBehaviour {

    // Use this for initialization


    public void Test()
    {
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene("MainScene");
    }
	// Update is called once per frame

}

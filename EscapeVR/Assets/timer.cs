using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class timer : MonoBehaviour {

    public Text timerText;
    private float startTime;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        AudioSource[] audio = GetComponents<AudioSource>();

        startTime = Time.timeSinceLevelLoad;

        float t = startTime;

        string minutes = ((int)t / 60).ToString();
        string seconds = (t % 60).ToString("f0");
        int warn = System.Int32.Parse(seconds);
        
        int temp = System.Int32.Parse(minutes);
        if (temp == 5)
        {

            Finnish();


        }
        if (warn == 58 && temp == 3)
        {
            timerText.color = Color.yellow;
            audio[1].Play();


        }

        if (warn<10) timerText.text = minutes + ":0" + seconds;

        else timerText.text = minutes + ":" + seconds;
	}

    public void Finnish()
    {
        timerText.color = Color.yellow;
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene("Loser");
        return;

    }
}

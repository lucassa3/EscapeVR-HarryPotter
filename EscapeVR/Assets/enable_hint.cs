using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class enable_hint : MonoBehaviour {
    public Rigidbody book;
    public GameObject blood;
    public GameObject hint;
    public GameObject tip;
    public GameObject door;
    private bool scream;
    

    // Use this for initialization
    void Start () {
        scream = true;
    }
	
	// Update is called once per frame
	void Update () {
        if (!book.IsSleeping() && door.GetComponent<CircularDrive>().enabled)
        {
            blood.SetActive(true);
            hint.SetActive(true);
            tip.SetActive(true);

            if (scream)
            {
                GetComponent<AudioSource>().Play();
                scream = false;
            }

        }

    }
}

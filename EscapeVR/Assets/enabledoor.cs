using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;


public class enabledoor : MonoBehaviour {
    public GameObject door;
    public GameObject video;


    private Hand.AttachmentFlags attachmentFlags = Hand.defaultAttachmentFlags & (~Hand.AttachmentFlags.SnapOnAttach) & (~Hand.AttachmentFlags.DetachOthers);

    // Use this for initialization
    void Start () {
        door.GetComponent<CircularDrive>().enabled = false;
	}

    private void OnHandHoverBegin(Hand hand) {
        door.GetComponent<CircularDrive>().enabled = true;
    }




    // Update is called once per frame
    void Update () {
        
    }
}
using UnityEngine;
using System.Collections;

public class hallwayTrigger : MonoBehaviour {

    void OnTriggerEnter(Collider other)
    {
        GameObject go = GameObject.Find("BathDoor");
        if (other.gameObject.tag == "Player" && DoorController.doorOpen)
        {
            DoorController.doorOpen = false;
            go.animation.Play("DoorClose");
        }

        if (tvTrigger.bathroomSetup)
        {
            GameObject go2 = GameObject.FindGameObjectWithTag("ZombieBathModel");
            go2.audio.Play();
        }
    }
}

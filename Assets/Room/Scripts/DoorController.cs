using UnityEngine;
using System.Collections;

public class DoorController : MonoBehaviour {
    public static bool doorOpen = false;

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player" && !DoorController.doorOpen)
        {
            DoorController.doorOpen = true;
            audio.Play();
            animation.Play("DoorOpen");
        }
	}
}

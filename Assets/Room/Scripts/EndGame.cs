using UnityEngine;
using System.Collections;

public class EndGame : MonoBehaviour {
    public bool endTriggered = false;

	void OnTriggerEnter(Collider other)
	{
        if (other.gameObject.tag == "Player" && !endTriggered)
        {
            endTriggered = true;
            audio.Play();
        }
	}
}

using UnityEngine;
using System.Collections;

public class BedCollision : MonoBehaviour {

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player")
			animation.Play("BedUp");
	}
}

using UnityEngine;
using System.Collections;

public class isVisible : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (renderer.isVisible == true)
		{
			//Debug.Log("Cube is visible");
		}
		else
		{
			//Debug.Log("Cube is Invisible");
		}
	
	}
}

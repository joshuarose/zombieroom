using UnityEngine;
using System.Collections;

public class MainDoor : MonoBehaviour {
    public static bool isNearMainDoor = false;
    public static bool attemptedToOpenDoor = false;
    public Texture tvTexture;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	    if(Input.GetKeyDown(KeyCode.F) && isNearMainDoor)
        {
            MainDoor.attemptedToOpenDoor = true;
            audio.Play();
            GameObject go = GameObject.Find("TV2");
            go.renderer.materials[1].mainTexture = tvTexture;
            go.audio.Play();
        }
	}

    void OnTriggerEnter(Collider other)
    {
        isNearMainDoor = true;
        GameObject go = GameObject.Find("mainDoorCanvas");
        go.GetComponent<Canvas>().enabled = true;
    }

    void OnTriggerExit(Collider other)
    {
        isNearMainDoor = false;
        GameObject go = GameObject.Find("mainDoorCanvas");
        go.GetComponent<Canvas>().enabled = false;
    }
}

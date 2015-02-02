using UnityEngine;
using System.Collections;

public class ToiletController : MonoBehaviour {
    public static bool isToiletOpen = false;
    public bool isNearToilet = false;
    public static bool hasWater = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F) && isNearToilet && isToiletOpen && !hasWater && tvTrigger.bathroomSetup)
        {
            hasWater = true;
            audio.Play();
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (!ToiletController.isToiletOpen && tvTrigger.bathroomSetup)
        {
            ToiletController.isToiletOpen = true;
            isNearToilet = true;
            GameObject go1 = GameObject.Find("toiletCanvas");
            go1.GetComponent<Canvas>().enabled = true;
            GameObject go2 = GameObject.FindGameObjectWithTag("shitter"); 
            go2.audio.Play();
            go2.animation.Play("PottyTime");
        }
    }
    
    void OnTriggerExit(Collider other)
    {
        GameObject go1 = GameObject.Find("toiletCanvas");
        go1.GetComponent<Canvas>().enabled = false;
        isNearToilet = false;
    }
}

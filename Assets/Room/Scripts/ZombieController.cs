using UnityEngine;
using System.Collections;

public class ZombieController : MonoBehaviour {

    public bool isNearZombie = false;
    public bool zombieKilled = false;
    public bool endOpened = false;
    
    void Update()
    {
        GameObject go = GameObject.FindGameObjectWithTag("ZombieBathTag");
        GameObject go2 = GameObject.FindGameObjectWithTag("ZombieBathModel");
        if (ToiletController.hasWater && isNearZombie)
        {
            GameObject go1 = GameObject.Find("bathCanvas");
            go1.GetComponent<Canvas>().enabled = true;
        }
        if (isNearZombie && Input.GetKeyDown(KeyCode.T) && go2.renderer.isVisible)
        {
            go.audio.Play();
            zombieKilled = true;
        }
        if (zombieKilled)
        {
            Destroy(go2);
            GameObject go3 = GameObject.FindGameObjectWithTag("BedTag");
            if (!endOpened)
            {
                go3.audio.Play();
                go3.animation.Play("BedUp");
                endOpened = true;
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        isNearZombie = true;
    }

    void OnTriggerExit(Collider other)
    {
        isNearZombie = false;
        GameObject go1 = GameObject.Find("bathCanvas");
        go1.GetComponent<Canvas>().enabled = false;
    }
}

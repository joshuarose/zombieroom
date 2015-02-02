using UnityEngine;
using System.Collections;

public class tvTrigger : MonoBehaviour {
    public Texture anything;
    public static bool zombieShown = false;
    public static bool zombieSeen = false;
    public static bool bathroomSetup = false;
    public GameObject zombieRoom;
    public GameObject zombieBath;
    public AudioSource[] audioArray;


	// Use this for initialization
	void Start () {
        audioArray = GetComponents<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
        if (zombieRoom == null)
        {
            zombieRoom = GameObject.FindGameObjectWithTag("ZombieRoomTag");
        }
        if (zombieBath == null)
        {
            zombieBath = GameObject.FindGameObjectWithTag("ZombieBathTag");
        }
        if (!tvTrigger.zombieShown && zombieRoom != null)
        {
            zombieRoom.SetActive(false);
            zombieBath.SetActive(false);
        }

        if (tvTrigger.zombieShown && zombieRoom != null && zombieRoom.renderer.isVisible)
        {
            audioArray[2].Stop();
            audioArray[1].Play();
            tvTrigger.zombieSeen = true;   
        }

        if (tvTrigger.zombieShown && zombieRoom != null && !zombieRoom.renderer.isVisible && tvTrigger.zombieSeen && zombieBath != null && !tvTrigger.bathroomSetup)
        {
            audioArray[3].Play();
            zombieRoom.SetActive(false);
            zombieBath.SetActive(true);
            tvTrigger.bathroomSetup = true;
        }
	}

    void OnTriggerEnter(Collider other)
    {
        if (MainDoor.attemptedToOpenDoor)
        {
            Material[] materials = renderer.materials;
            materials[1].mainTexture = anything;
            audio.Stop();
            audioArray[2].Play();
            if (zombieRoom == null)
            {
                zombieRoom = GameObject.FindGameObjectWithTag("ZombieRoomTag");
            }
            zombieRoom.SetActive(true);

            //TODO: Play sound effects for zombie intro
            tvTrigger.zombieShown = true;
        }
    }
}

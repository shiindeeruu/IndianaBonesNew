using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject deathTextObject;
    public GameObject trophyTextObject;
    // Start is called before the first frame update
    void Start()
    {
        deathTextObject.SetActive(false);
        trophyTextObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        /* 
         * ideas:
         * when you hit the tripwire, you trigger the walls to cave in/activate spikes
         *     probably close the door if the tripwire is triggered
         * putting bones/rocks/heavy objects on a pressure plate to open the door
         *     add some sort of weight factor
         *     maybe a minimum of 5lbs. to trigger the pressure plate
         * hidden bridge path 
         *     clues are on the wall/image on the wall that depicts what path
         *     should be taken
         * water room/final room
         *     find the lever
         *     rotate it to open up a valve to drain the water
         *     go up to grab the treasure
         * escape the dungeon (optional)
         *     outrun the boulder
         *     the old switcheroo
         *     idk
         */
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Spike"))
        {
            Debug.Log("sent back\n");
            deathTextObject.SetActive(true);
            transform.position = new Vector3(-0.019f, 1.173f, 3.226f);

        }

        if (other.gameObject.CompareTag("Trophy"))
        {
            trophyTextObject.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.CompareTag("Spike"))
        {
            deathTextObject.SetActive(false);

        }
    }
}

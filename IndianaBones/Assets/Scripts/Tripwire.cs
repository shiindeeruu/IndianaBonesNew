using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tripwire : MonoBehaviour
{
    public GameObject leftSpikes;
    public GameObject rightSpikes;
    //public float xLeft;
    //public float xRight;
    //public float y;
    //public float z;

    private Vector3 rightClosedPosition;
    private Vector3 rightOpenedPosition;
    private Vector3 leftClosedPosition;
    private Vector3 leftOpenedPosition;
    // Start is called before the first frame update
    void Start()
    {
        leftSpikes.SetActive(true);
        rightClosedPosition = rightSpikes.transform.position;
        rightOpenedPosition = new Vector3(rightClosedPosition.x + 2.354f, rightClosedPosition.y, rightClosedPosition.z);
        leftClosedPosition = leftSpikes.transform.position;
        leftOpenedPosition = new Vector3(leftClosedPosition.x - 2.354f, leftClosedPosition.y, leftClosedPosition.z);
        Debug.Log("rightOpenedPosition:" + rightOpenedPosition.ToString() + "\n");
        Debug.Log("leftOpenedPosition:" + leftOpenedPosition.ToString() + "\n");
        Debug.Log("rightClosedPosition:" + rightClosedPosition.ToString() + "\n");
        Debug.Log("leftClosedPosition:" + leftClosedPosition.ToString() + "\n");

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Bone"))
        {
            rightSpikes.transform.position = rightOpenedPosition;
            leftSpikes.transform.position = leftOpenedPosition;
            Debug.Log("Moved forward\n");
        }
        if (other != null)
        {
            rightSpikes.transform.position = rightOpenedPosition;
            leftSpikes.transform.position = leftOpenedPosition;
            Debug.Log("Moved forward\n");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Bone"))
        {
            rightSpikes.transform.position = rightClosedPosition;
            leftSpikes.transform.position = leftClosedPosition;
            leftSpikes.SetActive(false);
            rightSpikes.SetActive(false);
        }
        if (other != null)
        {
            rightSpikes.transform.position = rightClosedPosition;
            leftSpikes.transform.position = leftClosedPosition;
            rightSpikes.SetActive(false);
            leftSpikes.SetActive(false);
        }

    }
}

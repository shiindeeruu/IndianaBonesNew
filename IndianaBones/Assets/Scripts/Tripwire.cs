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
        rightClosedPosition = rightSpikes.transform.position;
        rightOpenedPosition = new Vector3(rightClosedPosition.x - 1.254f, rightClosedPosition.y, rightClosedPosition.z);
        leftClosedPosition = leftSpikes.transform.position;
        leftOpenedPosition = new Vector3(leftClosedPosition.x + 1.982f, leftClosedPosition.y, leftClosedPosition.z);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            rightSpikes.transform.position = rightOpenedPosition;
            leftSpikes.transform.position = leftOpenedPosition;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            rightSpikes.transform.position = rightClosedPosition;
            leftSpikes.transform.position = leftClosedPosition;
        }
            
    }
}

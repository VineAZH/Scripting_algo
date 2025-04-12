using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedTrigger : MonoBehaviour
{
    public float speedFactor = 2.5f;
    public int jumpFactor = 2;
    
    void OnTriggerEnter(Collider other)
    {
        other.GetComponent<FirstPersonMovement>().runSpeed *= speedFactor;
        other.GetComponent<FirstPersonMovement>().speed *= speedFactor;
        other.GetComponent<Jump>().jumpStrength *= jumpFactor;
    }
    void OnTriggerExit(Collider other)
    {
        other.GetComponent<FirstPersonMovement>().runSpeed /= speedFactor;
        other.GetComponent<Jump>().jumpStrength /= jumpFactor;
        other.GetComponent<FirstPersonMovement>().speed /= speedFactor;
    }
}

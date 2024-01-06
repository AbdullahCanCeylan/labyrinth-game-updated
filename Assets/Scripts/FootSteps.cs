using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootSteps : MonoBehaviour
{
    public AudioClip[] footStepClips;
    public AudioSource audioSource;
    public CharacterController controller;

    public float footStepThreshold;
    public float footStepRate;
    private float lastFootStepTime;

    private void FixedUpdate()
    {
        if (controller.velocity.magnitude > footStepThreshold)
        {   
            if (Time.time - lastFootStepTime > footStepRate)
            {
                lastFootStepTime = Time.time;
                audioSource.PlayOneShot(footStepClips[Random.Range(0, footStepClips.Length)]);
            }
        }
    }

}

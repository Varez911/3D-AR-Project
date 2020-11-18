using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Status : MonoBehaviour
{
    public Animator animator;
    public AudioSource audioOpening;

    public void soundOn()
    {
        Debug.Log("Tracked");
        audioOpening.Play();
    }

    public void soundOff()
    {
        Debug.Log("Lost Tracking");
        audioOpening.Stop();
    }
}

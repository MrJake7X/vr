using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugTest : MonoBehaviour
{
    [SerializeField]
    private AudioClip audioClip;
    [SerializeField]
    private AudioSource audioSource;

    public GameObject escribaObj;

    public void DebugButton()
    {
        Debug.Log("Button pressed");
        audioSource.clip = audioClip;
        audioSource.Play();

        escribaObj.SetActive(true);
    }

    public void EscribaInteraction()
    {
        Debug.Log("Escriba interacted");

        audioSource.clip = audioClip;
        audioSource.Play();

        escribaObj.SetActive(false);
    }
}

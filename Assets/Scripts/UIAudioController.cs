using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIAudioController : MonoBehaviour
{
    [SerializeField]
    private AudioClip buttonClickSound;

    private AudioSource audioSource;

    private void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
    }

    public void PlayButtonClick()
    {
        if (buttonClickSound != null)
        {
            audioSource.PlayOneShot(buttonClickSound);
        }
    }}

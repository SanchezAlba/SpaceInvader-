

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveAndCancellWithMusic : MonoBehaviour
{
    public string keyValue = "sfxVolume";
    private AudioSource audioSource;

    private void Awake()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
        audioSource.volume = PlayerPrefs.GetFloat(keyValue, 1.0f);
    }
}

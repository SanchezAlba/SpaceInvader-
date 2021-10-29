using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using TMPro;
using UnityEngine.EventSystems;

public class SoundEffects : MonoBehaviour, ISelectHandler
{
    public Button myButton;
    public TextMeshProUGUI myText;
    public Color defaultTextColor;
    public AudioSource effect;


    public void OnSelect(BaseEventData evenData)
    {
        effect.Play();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

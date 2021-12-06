using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using TMPro;
using UnityEngine.EventSystems;

public class musicaController : MonoBehaviour, ISelectHandler
{
    public AudioSource musicaBoton;
    public AudioSource musicaAnterior1;
    public AudioSource musicaAnterior2;
    public AudioSource musicaAnterior3;
    public Button myButton;

    public void OnSelect(BaseEventData eventData)
    {
        musicaBoton.Play();
        musicaAnterior1.Pause();
        musicaAnterior2.Pause();
        musicaAnterior3.Pause();
    }

}

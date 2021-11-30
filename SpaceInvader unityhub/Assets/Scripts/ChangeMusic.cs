using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using TMPro;
using UnityEngine.EventSystems;


// cuando selecciono algo cambia la musica y la de fondo se pausa

public class ChangeMusic : MonoBehaviour, ISelectHandler
{
    public AudioSource musicaBoton;
    public AudioSource musicaAnterior;
    public AudioSource musicaAnterior1;
    public AudioSource musicaAnterior2;
    public AudioSource musicaAnterior3;

        public void OnSelect(BaseEventData evenData)
    {
        musicaBoton.Play();
        musicaAnterior.Pause();
        musicaAnterior1.Pause();
        musicaAnterior2.Pause();
        musicaAnterior3.Pause();
    }

}

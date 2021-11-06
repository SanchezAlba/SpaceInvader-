using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicSource : MonoBehaviour
{
    public Slider sliderSound; //para tener acceso al valor
    public AudioSource musicSource;
    public AudioSource effectsSource;
    public Slider sliderEffects;

  public void SliderSoundModified()
    {
        musicSource.volume = sliderSound.value;
    }

    public void SliderEffectsModified()
    {
        musicSource.volume = sliderEffects.value;
    }

}

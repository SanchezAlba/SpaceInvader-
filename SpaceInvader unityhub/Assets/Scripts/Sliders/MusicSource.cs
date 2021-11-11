using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicSource : MonoBehaviour
{
    public static MusicSource instance;

    public Slider sliderMusic; //para tener acceso al valor
    public Slider sliderEffects;
   

    public AudioSource musicSource;
    public AudioSource effectsSource;  

  

    void Awake()
    {
        instance = this;
        InitializeVolume();
    }

    private void InitializeVolume()
    {
        sliderMusic.value = musicSource.volume;
        sliderEffects.value = effectsSource.volume;


    }

  public void SliderMusicModified()
    {
        musicSource.volume = sliderMusic.value;
       
    }

    public void SliderEffectsModified()
    {
        effectsSource.volume = sliderEffects.value;
        
    }
   
}

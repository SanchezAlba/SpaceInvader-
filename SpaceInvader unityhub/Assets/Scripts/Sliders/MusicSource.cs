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
    public AudioSource musica1;
    public AudioSource musica2;
    public AudioSource musica3;
    public AudioSource musica4;

    public AudioSource effectsSource;
    public AudioSource pantallasSource;

  

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

    public void SliderMusicModified1()
    {
        musica1.volume = sliderMusic.value;
        musica2.volume = sliderMusic.value;
        musica3.volume = sliderMusic.value;


    }


    public void SliderEffectsModified()
    {
        effectsSource.volume = sliderEffects.value;
        
    }

    public void SliderEffectsDonkey()

    {
        pantallasSource.volume = sliderEffects.value;
    }
}

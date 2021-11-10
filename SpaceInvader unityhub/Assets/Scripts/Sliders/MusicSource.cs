using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicSource : MonoBehaviour
{
    public Slider sliderMusic; //para tener acceso al valor
    public Slider sliderEffects;

    public AudioSource musicSource;
    public AudioSource effectsSource;
    

    public Image imagenMute;

    private void InitializeVolume()
    {
        effectsSource.volume = PlayerPrefs.GetFloat("effectsVolumen", 1.0f);
        musicSource.volume = PlayerPrefs.GetFloat("musicVolumen", 1.0f);

        sliderMusic.value = musicSource.volume;
        sliderEffects.value = effectsSource.volume;
    }

  public void SliderMusicModified()
    {
        musicSource.volume = sliderMusic.value;
        PlayerPrefs.SetFloat("musicVolumen", musicSource.volume);
        PlayerPrefs.Save();
    }

    public void SliderEffectsModified()
    {
        musicSource.volume = sliderEffects.value;
        PlayerPrefs.SetFloat("effectsVolumen", effectsSource.volume);
        PlayerPrefs.Save();
    }

    /*public void RevisarSiEstoyMute()
    {
        if(sliderMusic == 0)
        {
            imagenMute.enabled = true;
        }
        else
        {
            imagenMuete.enable = false;
        }
    }*/
}

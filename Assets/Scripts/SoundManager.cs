using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    [SerializeField] private Slider _musicSlider;
    [SerializeField] private AudioSource _musicSource;

    private void Start()
    {
        if (PlayerPrefs.HasKey("soundVolume"))
            LoadVolume();
        else
        {
            PlayerPrefs.SetFloat("soundVolume", 0.5f);
            LoadVolume();
        }
    }

    public void SetVolume()
    {
        _musicSource.volume = _musicSlider.value;
        SaveVolume();
  //      AudioListener.volume = _musicSlider.value;
    //    SaveVolume();
    }

    private void SaveVolume()
    {
        PlayerPrefs.SetFloat("soundVolume", _musicSlider.value);
    }

    private void LoadVolume()
    {
  //      PlayerPrefs.GetFloat("soundVolume", _musicSlider.value);
        float volume = PlayerPrefs.GetFloat("soundVolume");
   //     _musicSlider.value = PlayerPrefs.GetFloat("soundVolume");
        _musicSlider.value = volume;
        _musicSource.volume = volume;
    }
}
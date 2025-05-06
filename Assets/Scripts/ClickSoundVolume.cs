using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickSoundVolume : MonoBehaviour
{
    [SerializeField] private Slider _clickSlider;
    [SerializeField] private AudioSource _audioSource;

    private void Start()
    {
        if (PlayerPrefs.HasKey("ClickVolume"))
        {
            LoadClickVolume();
        }
        else
        {
            PlayerPrefs.SetFloat("ClickVolume", 1);
            LoadClickVolume();
        }
    }

    public void SetButtonClickVolume()
    {
        _audioSource.volume = _clickSlider.value;
        SaveClickVolume();
    }

    private void SaveClickVolume()
    {
        PlayerPrefs.SetFloat("ClickVolume",_clickSlider.value);
    }

    private void LoadClickVolume()
    {
        float saveVolume = PlayerPrefs.GetFloat("ClickVolume");
        _clickSlider.value = saveVolume;
        _audioSource.volume = saveVolume;
    }
}
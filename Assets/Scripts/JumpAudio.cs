using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpAudio : MonoBehaviour
{
    [SerializeField] private AudioSource _audioSource;

    public void OnJumpAudio()
    {
        _audioSource.Play();
    }

    public void OffJumpAudio()
    {
        _audioSource.Stop();
    }

    public void AudioMute()
    {
        _audioSource.mute = true;
    }
}
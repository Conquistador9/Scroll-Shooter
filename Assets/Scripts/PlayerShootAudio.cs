using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShootAudio : MonoBehaviour
{
    private AudioSource _audioSource;

    private void Start()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    public void ShootAudio()
    {
        _audioSource.Play();
    }
}
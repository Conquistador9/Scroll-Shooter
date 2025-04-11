using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamageAudio : MonoBehaviour
{
    [SerializeField] private AudioSource _audioSource;

    public void DamageAudio()
    {
        _audioSource.Play();
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioClips : MonoBehaviour
{
    [SerializeField] private AudioClip _clipShoot, _clipDamage;
    private AudioSource _audioSource;

    private void Start()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    public void ShootClip()
    {
        _audioSource.clip = _clipShoot;
        _audioSource.Play();
    }

    public void DamageClip()
    {
        _audioSource.clip = _clipDamage;
        _audioSource.Play();
    }
}
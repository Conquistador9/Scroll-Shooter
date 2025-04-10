using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaiseWeapon : MonoBehaviour
{
    [SerializeField] private AmmoCount _ammoCount;
    private AudioSource _audioSource;
    private SpriteRenderer _spriteRenderer;
    private BoxCollider2D _boxCollider;

    private void Start()
    {
        _audioSource = GetComponent<AudioSource>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _boxCollider = GetComponent<BoxCollider2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            _audioSource.Play();
            _spriteRenderer.enabled = false;
            _boxCollider.enabled = false;
            _ammoCount.AddAmmo();
            Destroy(gameObject, 1);
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour
{
    [SerializeField] private GameObject _explosion;
    private SpriteRenderer _spriteRenderer;

    private void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Bullet"))
        {
            _spriteRenderer.enabled = false;
            _explosion.SetActive(true);
            Destroy(_explosion, 0.5f);
            Destroy(gameObject, 0.10f);
        }
    }
}
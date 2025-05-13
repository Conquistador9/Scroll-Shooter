using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeactiveExplosions : MonoBehaviour
{
    [SerializeField] private GameObject _explosions;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")) _explosions.SetActive(false);
    }
}
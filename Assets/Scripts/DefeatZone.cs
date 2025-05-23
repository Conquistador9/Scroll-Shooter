using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefeatZone : MonoBehaviour
{
    [SerializeField] private PlayerHealth _playerHealth;
    private int _damage = 100;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            _playerHealth.TakeDamage(_damage);
        }
    }
}
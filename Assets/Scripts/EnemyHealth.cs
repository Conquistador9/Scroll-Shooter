using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] private EnemyCollected _enemyCollected;
    private int _maxHealth = 100;
    private int _currentHealth;

    private void Start()
    {
        _currentHealth = _maxHealth;
    }

    public void TakeDamage(int health)
    {
        _currentHealth -= health;

        if(_currentHealth <= 0)
        {
            _enemyCollected.AddKill();
            Destroy(gameObject);
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private TMP_Text _healthText;
    private PlayerDamageAudio _damageAudio;
    private int _maxHealth = 100;
    private int _currentHealth;

    private void Start()
    {
        _damageAudio = GetComponent<PlayerDamageAudio>();
        _currentHealth = _maxHealth;
    }

    private void Update()
    {
        _healthText.text = _currentHealth.ToString();
    }

    public void TakeDamage(int damage)
    {
        _currentHealth -= damage;
        _damageAudio.DamageAudio();

        if(_currentHealth <= 0)
        {
            _currentHealth = 0;
            Destroy(gameObject, 0.2f);
        }
    }

    public void AddHealth(int health)
    {
        _currentHealth += health;

        if(_currentHealth > _maxHealth)
        {
            _currentHealth = _maxHealth;
        }
    }
}
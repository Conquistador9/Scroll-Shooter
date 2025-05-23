using System.Collections;
using System.Collections.Generic;
using System.Threading;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private EnemyCollected _enemyCollected;
    [SerializeField] private TMP_Text _healthText;
    [SerializeField] private GameObject _jumpAudioObject;
    private Rigidbody2D _rb;
    private SpriteRenderer _spriteRenderer;
    private CapsuleCollider2D _capsuleCollider;
    private PlayerDamageAudio _damageAudio;
    private JumpAudio _jumpAudio;
    private PlayerController _playerController;
    private int _maxHealth = 100;
    private int _currentHealth;

    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _capsuleCollider = GetComponent<CapsuleCollider2D>();
        _damageAudio = GetComponent<PlayerDamageAudio>();
        _jumpAudio = GetComponent<JumpAudio>();
        _playerController = GetComponent<PlayerController>();
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
            _playerController.enabled = false;
            _jumpAudio.AudioMute();
            _rb.constraints = RigidbodyConstraints2D.FreezeAll;
            StartCoroutine(DeactivePlayer());
            _spriteRenderer.enabled = false;
            _capsuleCollider.enabled = false;
            _enemyCollected.SaveData();
            Destroy(gameObject, 2f);
            SceneManager.LoadScene(3);
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

    private IEnumerator DeactivePlayer()
    {
        yield return new WaitForSeconds(0.2f);
        gameObject.SetActive(false);
    }
}
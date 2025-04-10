using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ActiveExplosions : MonoBehaviour
{
    [SerializeField] private GameObject _explosions;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            _explosions.SetActive(true);
        }
    }
}
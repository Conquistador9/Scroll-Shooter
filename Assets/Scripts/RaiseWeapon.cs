using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaiseWeapon : MonoBehaviour
{
    [SerializeField] private AmmoCount _ammoCount;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            _ammoCount.AddAmmo();
            Destroy(gameObject);
        }
    }
}
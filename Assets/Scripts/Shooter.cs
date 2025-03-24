using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] private GameObject _fire;
    [SerializeField] private Transform _firePoint;
    [SerializeField] private float _fireSpeed;

    public void Shoot()
    {
        GameObject currentFire = Instantiate(_fire, _firePoint.position, Quaternion.identity);
        Rigidbody2D currentFireVelocity = currentFire.GetComponent<Rigidbody2D>();
        currentFireVelocity.velocity = new Vector2(-_fireSpeed, 0);
    }
}
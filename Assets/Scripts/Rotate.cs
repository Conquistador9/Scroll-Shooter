using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    [Range(0, 1000f)][SerializeField] private float _speed;

    private void Update()
    {
        transform.Rotate(0, _speed * Time.deltaTime, 0);
    }
}
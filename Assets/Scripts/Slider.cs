using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slider : MonoBehaviour
{
    [SerializeField] private SliderJoint2D _slider;
    [SerializeField] private float _upSpeed;
    [SerializeField] private float _downSpeed;
    private bool _isMoving;

    private void Update()
    {
        if (_isMoving)
        {
            JointMotor2D motor = _slider.motor;
            motor.motorSpeed = _upSpeed;
            _slider.motor = motor;
        }
        else if (!_isMoving)
        {
            JointMotor2D motor = _slider.motor;
            motor.motorSpeed = _downSpeed;
            _slider.motor = motor;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Upper")) _isMoving = false;

        if (collision.gameObject.CompareTag("Lower")) _isMoving = true;
    }
}
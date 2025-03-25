using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    [SerializeField] private Transform _startPoint;
    [SerializeField] private Transform _endPoint;
    [SerializeField] private float _speed;
    private bool _isMoving = true;

    void Update()
    {
        Vector3 targetPosition = _isMoving ? _endPoint.position : _startPoint.position;
        transform.position = Vector2.MoveTowards(transform.position, targetPosition, _speed * Time.deltaTime);

        if (Vector3.Distance(transform.position, targetPosition) < 0.1f)
        {
            _isMoving = !_isMoving;
            transform.localScale = new Vector2(-transform.localScale.x, transform.localScale.y);
        }
    }
}
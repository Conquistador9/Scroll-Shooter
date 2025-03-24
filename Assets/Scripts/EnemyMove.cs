using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    [SerializeField] private Transform startPoint;
    [SerializeField] private Transform endPoint;

    // Скорость движения объекта
    [SerializeField] private float speed = 5f;

    // Флаг для определения направления движения
    private bool movingForward = true;

    void Update()
    {
        // Вычисляем направление движения
        Vector3 targetPosition = movingForward ? endPoint.position : startPoint.position;

        // Перемещаем объект к целевой точке
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);

        // Проверяем, достиг ли объект целевой точки
        if (Vector3.Distance(transform.position, targetPosition) < 0.1f)
        {
            // Разворачиваем объект и меняем направление движения
            movingForward = !movingForward;
            transform.localScale = new Vector2(-transform.localScale.x, transform.localScale.y);
        }
    }
}
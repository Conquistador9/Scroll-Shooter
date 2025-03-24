using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    [SerializeField] private Transform startPoint;
    [SerializeField] private Transform endPoint;

    // �������� �������� �������
    [SerializeField] private float speed = 5f;

    // ���� ��� ����������� ����������� ��������
    private bool movingForward = true;

    void Update()
    {
        // ��������� ����������� ��������
        Vector3 targetPosition = movingForward ? endPoint.position : startPoint.position;

        // ���������� ������ � ������� �����
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);

        // ���������, ������ �� ������ ������� �����
        if (Vector3.Distance(transform.position, targetPosition) < 0.1f)
        {
            // ������������� ������ � ������ ����������� ��������
            movingForward = !movingForward;
            transform.localScale = new Vector2(-transform.localScale.x, transform.localScale.y);
        }
    }
}
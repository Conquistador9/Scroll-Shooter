using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DotweenButtonScale : MonoBehaviour
{
    [SerializeField] private Transform _button;

    private void Start()
    {
        _button.DOScale(2.1211338f, 1);
    }
}
using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dotween : MonoBehaviour
{
    [SerializeField] private Transform _playButton,_settingsButton;

    private void Start()
    {
        _playButton.DOMoveX(-6.7f, 0.8f);
        _settingsButton.DOMoveX(-6.7f, 0.8f);
    }

    public void ButtonsRight()
    {
        _playButton.DOMoveX(-6.7f, 1.5f);
        _settingsButton.DOMoveX(-6.7f, 1.5f);
    }

    public void ButtonsLeft()
    {
        _playButton.DOMoveX(-12, 0.2f);
        _settingsButton.DOMoveX(-15, 0.1f);
    }
}
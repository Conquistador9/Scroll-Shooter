using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dotween : MonoBehaviour
{
    [Header("Buttons")]
    [SerializeField] private Transform _playButton;
    [SerializeField] private Transform _settingsButton;
    [SerializeField] private Transform _quitButton;

    [Header("Message")]
    [SerializeField] private Transform _quitMessage;

    private void Start()
    {
        _playButton.DOMoveX(-6.7f, 0.8f);
        _settingsButton.DOMoveX(-6.7f, 0.8f);
        _quitButton.DOMoveX(-6.7f, 0.8f);
    }

    public void ButtonsRight()
    {
        _playButton.DOMoveX(-6.7f, 1);
        _settingsButton.DOMoveX(-6.7f, 1);
        _quitButton.DOMoveX(-6.7f, 1);
    }

    public void ButtonsLeft()
    {
        _playButton.DOMoveX(-12, 0.2f);
        _settingsButton.DOMoveX(-15, 0.1f);
        _quitButton.DOMoveX(-18, 0.1f);
    }

    public void QuitMessageDown() => _quitMessage.DOMoveY(-7, 0.2f);

    public void QuitMessageUp() => _quitMessage.DOMoveY(0, 0.2f);
}
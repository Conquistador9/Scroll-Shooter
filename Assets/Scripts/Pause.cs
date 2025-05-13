using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    [SerializeField] PlayerShootAudio _playerShootAudio;
    [SerializeField] private JumpAudio _jumpAudio;
    [SerializeField] private GameObject _pausePanel;
    [SerializeField] private PlayerController _playerController;
    [SerializeField] private PlayerShoot _playerShoot;
    [SerializeField] private AmmoCount _ammoCount;

    public void GamePause()
    {
        Time.timeScale = 0;
        _pausePanel.SetActive(true);
        _playerShootAudio.StopShootAudio();

        if (_pausePanel)
        {
            _jumpAudio.PauseAudio();
        }
    }

    public void UnPause()
    {
        _pausePanel.SetActive(false);
        Time.timeScale = 1;
        _playerController.enabled = true;
        _playerShoot.enabled = true;
        _ammoCount.enabled = true;
        _jumpAudio.AudioMuteOff();
        _jumpAudio.UnPauseAudio();
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    [SerializeField] private GameObject _pausePanel;

    public void GamePause()
    {
        Time.timeScale = 0;
        _pausePanel.SetActive(true);
    }

    public void UnPause()
    {
        Time.timeScale = 1;
    }
}
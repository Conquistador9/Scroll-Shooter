using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerState : MonoBehaviour
{
    [SerializeField] private GameObject _playerIdle;
    [SerializeField] private GameObject _playerRun;
    [SerializeField] private GameObject _playerLadder;
    [SerializeField] private GameObject _playerJump;

    public void Idle()
    {
        _playerIdle.SetActive(true);
        _playerRun.SetActive(false);
        _playerLadder.SetActive(false);
        _playerJump.SetActive(false);
    }

    public void Run()
    {
        _playerRun.SetActive(true);
        _playerIdle.SetActive(false);
        _playerLadder.SetActive(false);
        _playerJump.SetActive(false);
    }

    public void Ladder()
    {
        _playerLadder.SetActive(true);
        _playerIdle.SetActive(false);
        _playerRun.SetActive(false);
        _playerJump.SetActive(false);
    }

    public void Jump()
    {
        _playerJump.SetActive(true);
        _playerIdle.SetActive(false);
        _playerRun.SetActive(false);
        _playerLadder.SetActive(false);
    }
}
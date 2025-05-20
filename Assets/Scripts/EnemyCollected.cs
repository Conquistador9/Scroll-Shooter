using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyCollected : MonoBehaviour
{
    [SerializeField] private TMP_Text _enemyCountText, _enemyCountTextTwo;
    private int _enemyCount;
    private int _level = 1;
    private int _levelTwo = 2;

    private void Start()
    {
        LoadData();
    }

    private void Update()
    {
        EnemyCountText();
    }

    public void AddKill()
    {
        _enemyCount++;
        EnemyCountText();

        if(_enemyCount == 4)
        {
            SaveData();
            SceneManager.LoadScene(2);
        }
    }

    public void EnemyCountDelete()
    {
        PlayerPrefs.DeleteKey("EnemyCount");
    }

    private void EnemyCountText()
    {
        _enemyCountText.text = _enemyCount.ToString();
        _enemyCountTextTwo.text = _enemyCount.ToString();
    }

    private void SaveData()
    {
        PlayerPrefs.SetInt("EnemyCount", _enemyCount);
        PlayerPrefs.Save();
    }

    private void LoadData()
    {
        int currentScene = SceneManager.GetActiveScene().buildIndex;

        if(currentScene == _level)
        {
            _enemyCount = 0;
        }
        else if(currentScene == _levelTwo)
        {
            _enemyCount = PlayerPrefs.GetInt("EnemyCount", 0);
        }
    }
}
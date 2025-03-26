using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EnemyCollected : MonoBehaviour
{
    [SerializeField] private TMP_Text _enemyCountText;
    private int _enemyCount;

    private void Update()
    {
        EnemyCountText();
    }

    public void AddKill()
    {
        _enemyCount++;
        EnemyCountText();
    }

    private void EnemyCountText()
    {
        _enemyCountText.text = _enemyCount.ToString();

    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Repeat : MonoBehaviour
{
    public void RepeatGame()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1;
    }
}
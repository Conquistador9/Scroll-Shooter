using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BackToMenu : MonoBehaviour
{
    [SerializeField] private Button _button;

    public void ClickButton()
    {
        _button.interactable = false;
        StartCoroutine(Menu());
    }

    private IEnumerator Menu()
    {
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene(0);
    }
}
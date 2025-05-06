using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsPanel : MonoBehaviour
{
    [SerializeField] private GameObject _panel;
    [SerializeField] private AudioSource _audioSource;

    public void OnSettings()
    {
        _audioSource.Play();
        StartCoroutine(DelaySetting());
    }

    public void OffSettings()
    {
        _audioSource.Play();
        StartCoroutine(DelayOffSettings());

    }

    private IEnumerator DelaySetting()
    {
        yield return new WaitForSeconds(0.3f);
        _panel.transform.SetAsLastSibling();
   //     _panel.SetActive(true);
    }

    private IEnumerator DelayOffSettings()
    {
        yield return new WaitForSeconds(0.2f);
        _panel.transform.transform.SetAsFirstSibling();
        //      _panel.SetActive(false);
    }
}
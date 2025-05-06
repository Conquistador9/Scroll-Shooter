using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class MousePosition : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField] private PlayerController _playerController;
    [SerializeField] private PlayerShoot _playerShoot;
    [SerializeField] private AmmoCount _ammoCount;

    public void OnPointerEnter(PointerEventData evetData)
    {
        _playerController.enabled = false;
        _playerShoot.enabled = false;
        _ammoCount.enabled = false;
        Debug.Log("kek");
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        _playerController.enabled = true;
        _playerShoot.enabled = true;
        _ammoCount.enabled = true;
        Debug.Log("goooo");
    }
}
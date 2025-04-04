using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class AmmoCount : MonoBehaviour
{
    [SerializeField] private TMP_Text _ammoText;
    private PlayerShoot _playerShoot;
    private int _ammoCount = 8;
    private bool _isCheckAmmo = false;

    private void Start()
    {
        _playerShoot = GetComponent<PlayerShoot>();
    }

    private void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");

        if(_ammoCount > 0 && Input.GetButtonDown("Fire1"))
        {
            _playerShoot.Shoot(horizontal);
            _isCheckAmmo = false;
            DeductionAmmo();
        }
        else if(_ammoCount == 0 && !_isCheckAmmo)
        {
            _playerShoot.enabled = false;
            _isCheckAmmo = true;
        }
            AmmoCountText();
    }

    public void AddAmmo()
    {
        StartCoroutine(Reload());
        AmmoCountText();
    }

    public void DeductionAmmo()
    {
        _ammoCount--;

        if(_ammoCount <= 0)
        {
            _ammoCount = 0;
        }

        AmmoCountText();
    }

    private void AmmoCountText()
    {
        _ammoText.text = _ammoCount.ToString();
    }

    private IEnumerator Reload()
    {
        yield return new WaitForSeconds(1);
        _ammoCount += 5;
    }
}
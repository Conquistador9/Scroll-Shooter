using System.Collections;
using UnityEngine;

public class Explosions : MonoBehaviour
{
    [SerializeField] private GameObject[] _explosions;

    private void Start()
    {
        StartCoroutine(ExplosionsActive());
    }

    private IEnumerator ExplosionsActive()
    {
        int currentExplosion = 0;

        while (true)
        {
            _explosions[currentExplosion].SetActive(true);

            yield return new WaitForSeconds(0.6f);
            _explosions[currentExplosion].SetActive(false);
            currentExplosion++;

            if(currentExplosion >= _explosions.Length) currentExplosion = 0;
        }
    }
}
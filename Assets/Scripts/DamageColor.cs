using System.Collections;
using UnityEngine;

public class DamageColor : MonoBehaviour
{
    private SpriteRenderer _spriteRenderer;
    private Color _color;

    private void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _color = _spriteRenderer.color;
    }

    public void ChangeColor()
    {
        _spriteRenderer.color = Color.red;
        StartCoroutine(ColorBack());
    }

    private IEnumerator ColorBack()
    {
        yield return new WaitForSeconds(0.1f);
        _spriteRenderer.color = _color;
    }
}
using UnityEngine;

public class DestroyFire : MonoBehaviour
{
    private SpriteRenderer _spriteRenderer;
    private CircleCollider2D _circleCollider;

    private void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _circleCollider = GetComponent<CircleCollider2D>();
        Destroy(gameObject, 2);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            _spriteRenderer.enabled = false;
            _circleCollider.enabled = false;
      //      Destroy(gameObject);
        }
    }
}
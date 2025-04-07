using UnityEngine;

public class EnemyRaycast : MonoBehaviour
{
    [SerializeField] private LayerMask _layerMask;
    [SerializeField] private float _distance;
    private Animator _animator;

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }

    private void FixedUpdate()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.left, _distance, _layerMask);
        Debug.DrawRay(transform.position, Vector2.left * _distance, Color.red);
        
        if(Physics2D.Raycast(transform.position,Vector2.left, _distance, _layerMask)) _animator.enabled = true;
        else _animator.enabled = false;
    }
}
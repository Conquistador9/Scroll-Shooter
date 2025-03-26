using UnityEngine;

public class PlayerAnimations : MonoBehaviour
{
    private Animator _animator;

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }

    public void Idle() => _animator.SetBool("Walk", false);

    public void Walk() => _animator.SetBool("Walk", true);

    public void Jump() => _animator.SetBool("Jump", true);

    public void JumpOf() => _animator.SetBool("Jump", false);
}
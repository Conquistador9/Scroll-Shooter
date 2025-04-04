using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    [Header("Components")]
    [SerializeField] private GameObject _fireEnergy;
    [SerializeField] private Transform _energyPoint;

    [Header("Setting")]
    [SerializeField] private float _energySpeed;

    private void Start()
    {
        EnergySpriteRight();
    }

    public void Shoot(float direction)
    {
        GameObject currentBullet = Instantiate(_fireEnergy, _energyPoint.position, Quaternion.identity);
        Rigidbody2D currentBulletVelocity = currentBullet.GetComponent<Rigidbody2D>();
        Vector3 line;

        if (direction >= 0) currentBulletVelocity.velocity = new Vector2(_energySpeed * 1, currentBulletVelocity.velocity.y);
        else currentBulletVelocity.velocity = new Vector2(_energySpeed * -1, currentBulletVelocity.velocity.y);

        if (transform.localScale.x < 0) line = -_energyPoint.right;
        else line = _energyPoint.right;

        currentBulletVelocity.GetComponent<Rigidbody2D>().velocity = line * _energySpeed;
    }

    public void EnergySpriteRight() => _fireEnergy.GetComponent<SpriteRenderer>().flipX = false;

    public void EnergySpriteLeft() => _fireEnergy.GetComponent<SpriteRenderer>().flipX = true;
}
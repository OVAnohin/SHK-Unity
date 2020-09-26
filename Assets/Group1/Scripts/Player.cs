using UnityEngine;

[RequireComponent(typeof(CircleCollider2D))]
[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(PlayerMover))]

public class Player : MonoBehaviour
{
  [SerializeField] private float _circleRadius = 0.2f;

  private CircleCollider2D _collider2D;
  private Rigidbody2D _rigidbody2D;
  private PlayerMover _playerMover;

  public void GetSpeedBoost(SpeedBoost element)
  {
    _playerMover.TemporarySpeedBoost(element);
  }

  private void Start()
  {
    _collider2D = GetComponent<CircleCollider2D>();
    _rigidbody2D = GetComponent<Rigidbody2D>();
    _rigidbody2D.isKinematic = true;
    _collider2D.radius = _circleRadius;
    _playerMover = GetComponent<PlayerMover>();
  }
}

using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(CircleCollider2D))]
public abstract class Character : MonoBehaviour
{
  [SerializeField] private float _circleColliderRadius = 0.2f;

  private CircleCollider2D _circleCollider2D;

  private void Awake()
  {
    _circleCollider2D = GetComponent<CircleCollider2D>();
    _circleCollider2D.radius = _circleColliderRadius;
    _circleCollider2D.isTrigger = true;
  }

  protected abstract void OnTriggerEnter2D(Collider2D collision);
}

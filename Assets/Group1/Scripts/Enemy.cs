using UnityEngine;
using UnityEngine.Events;

public class Enemy : ObjectEnemy
{
  [SerializeField] private float _speed = 2;
  [SerializeField] private int _nextWaypointRadius = 4;

  private Vector3 _nextWaypoint;

  public event UnityAction<Enemy> Dying;

  private void Start()
  {
    SetNextWaypoint();
  }

  private void Update()
  {
    transform.position = Vector3.MoveTowards(transform.position, _nextWaypoint, _speed * Time.deltaTime);

    if (transform.position == _nextWaypoint)
      SetNextWaypoint();
  }

  private void SetNextWaypoint()
  {
    _nextWaypoint = Random.insideUnitCircle * _nextWaypointRadius;
  }

  protected override void OnTriggerEnter2D(Collider2D collision)
  {
    if (collision.GetComponent<Player>() != null)
    {
      Destroy(gameObject);
      Dying?.Invoke(this);
    }
  }
}

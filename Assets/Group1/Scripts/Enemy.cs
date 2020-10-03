using UnityEngine;
using UnityEngine.Events;

public class Enemy : Character
{
    [SerializeField] private float _speed = 2;
    [SerializeField] private int _nextWaypointRadius = 4;

    private Vector3 _nextWaypoint;

    public event UnityAction<Enemy> Died;

    private void Start()
    {
        GenerateWaypoint();
    }

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, _nextWaypoint, _speed * Time.deltaTime);

        if (transform.position == _nextWaypoint)
            GenerateWaypoint();
    }

    private void GenerateWaypoint()
    {
        _nextWaypoint = Random.insideUnitCircle * _nextWaypointRadius;
    }

    protected override void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Player>() != null)
        {
            Destroy(gameObject);
            Died?.Invoke(this);
        }
    }
}

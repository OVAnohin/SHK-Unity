using System.Collections;
using UnityEngine;

public class PlayerMover : MonoBehaviour
{
  [SerializeField] private float _speed = 4;
  [SerializeField] private bool _isTimeSpeedUp = false;
  [SerializeField] private float _fastSpeedTime = 2;
  [SerializeField] private float _deltaSpeed = 2;

  private void Start()
  {
    if (_isTimeSpeedUp)
      StartCoroutine(SetPlayerMoveFaster());
  }

  private void Update()
  {
    float vertical = Input.GetAxis("Vertical") * _speed * Time.deltaTime;
    float horizontal = Input.GetAxis("Horizontal") * _speed * Time.deltaTime;

    transform.Translate(horizontal, vertical, 0);
  }

  public void TemporarySpeedBoost(SpeedBoost element)
  {
    if (element != null)
      StartCoroutine(SetPlayerMoveFaster());

  }

  private IEnumerator SetPlayerMoveFaster()
  {
    float elapsedTime = _fastSpeedTime;
    _speed *= _deltaSpeed;

    while (elapsedTime > 0)
    {
      elapsedTime -= Time.deltaTime;
      yield return null;
    }

    _speed /= _deltaSpeed;
  }
}

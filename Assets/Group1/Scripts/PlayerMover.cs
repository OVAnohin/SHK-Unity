using System;
using System.Collections;
using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    [SerializeField] private float _speed = 4;
    [SerializeField] private float _fastSpeedTime = 2;
    [SerializeField] private float _deltaSpeed = 2;

    private void Update()
    {
        Move(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
    }

    private void Move(float horizontal, float vertical)
    {
        transform.Translate(horizontal * _speed * Time.deltaTime, vertical * _speed * Time.deltaTime, 0);
    }

    public void BoostSpeed(SpeedBoost booster)
    {
        if (booster == null)
            throw new Exception("Booster is null");

        StartCoroutine(ActivateSpeedBoost());
    }

    private IEnumerator ActivateSpeedBoost()
    {
        _speed *= _deltaSpeed;

        yield return new WaitForSeconds(_fastSpeedTime);

        _speed /= _deltaSpeed;
    }
}

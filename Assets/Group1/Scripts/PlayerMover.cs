using System.Collections;
using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    [SerializeField] private float _speed = 4;
    [SerializeField] private float _fastSpeedTime = 2;
    [SerializeField] private float _deltaSpeed = 2;


    private void Update()
    {
        float vertical = GetAxisInput("Vertical");
        float horizontal = GetAxisInput("Horizontal");

        transform.Translate(horizontal, vertical, 0);
    }

    private float GetAxisInput(string axis)
    {
        return Input.GetAxis(axis) * _speed * Time.deltaTime;
    }

    public void InvokeSpeedBoost(SpeedBoost element)
    {
        if (element != null)
            StartCoroutine(MoveFaster());

    }

    private IEnumerator MoveFaster()
    {
        _speed *= _deltaSpeed;

        yield return new WaitForSeconds(_fastSpeedTime);

        _speed /= _deltaSpeed;
    }
}

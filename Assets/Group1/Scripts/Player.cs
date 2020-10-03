using UnityEngine;

[RequireComponent(typeof(PlayerMover))]
public class Player : MonoBehaviour
{
    private PlayerMover _playerMover;

    public void TakeSpeedBoost(SpeedBoost element)
    {
        _playerMover.InvokeSpeedBoost(element);
    }

    private void Start()
    {
        _playerMover = GetComponent<PlayerMover>();
    }
}

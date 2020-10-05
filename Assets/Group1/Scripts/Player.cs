using UnityEngine;

[RequireComponent(typeof(PlayerMover))]
public class Player : MonoBehaviour
{
    private PlayerMover _playerMover;

    private void Start()
    {
        _playerMover = GetComponent<PlayerMover>();
    }

    public void BoostSpeed(SpeedBoost booster)
    {
        _playerMover.BoostSpeed(booster);
    }

}

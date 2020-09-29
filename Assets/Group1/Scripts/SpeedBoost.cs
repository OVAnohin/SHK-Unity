using UnityEngine;
using UnityEngine.Events;

public class SpeedBoost : Character
{
  protected override void OnTriggerEnter2D(Collider2D collision)
  {
    if (collision.GetComponent<Player>() != null)
    {
      collision.GetComponent<Player>().TakeSpeedBoost(this);
    }
  }
}

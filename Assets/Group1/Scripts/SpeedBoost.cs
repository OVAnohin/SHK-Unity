using UnityEngine;
using UnityEngine.Events;

public class SpeedBoost : ObjectEnemy
{
  protected override void OnTriggerEnter2D(Collider2D collision)
  {
    if (collision.GetComponent<Player>() != null)
    {
      collision.GetComponent<Player>().GetSpeedBoost(this);
    }
  }
}

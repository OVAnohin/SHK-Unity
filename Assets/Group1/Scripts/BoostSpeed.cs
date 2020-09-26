using UnityEngine;

public class BoostSpeed : Enemy
{
  private void OnTriggerEnter2D(Collider2D collision)
  {
    if (collision.GetComponent<Player>() != null)
    {
      collision.GetComponent<Player>().BoostSpeed(this);
    }
  }
}

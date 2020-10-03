using UnityEngine;

public abstract class Character : MonoBehaviour
{
    protected abstract void OnTriggerEnter2D(Collider2D collision);
}

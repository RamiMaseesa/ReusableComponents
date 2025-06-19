using UnityEngine;
using MyGame.Interfaces;
public class PlayerHit : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision) {
        IHealth health = collision.gameObject.GetComponent<IHealth>();
        if (health == null) return;

        health.RemoveHealthPoints(1);
        Destroy(gameObject);
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        IHealth health = collision.gameObject.GetComponent<IHealth>();
        if (health == null) return;

        health.RemoveHealthPoints(1);
        Destroy(gameObject);
    }
}

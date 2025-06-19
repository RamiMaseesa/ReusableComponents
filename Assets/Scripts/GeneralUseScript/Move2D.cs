using UnityEngine;
using MyGame.Interfaces;
public class Move2D : MonoBehaviour, IMove {

    [SerializeField] private float speed;
    Rigidbody2D rb => GetComponent<Rigidbody2D>();
    public void MoveToDirection2D(Vector2 direction) {
        rb.AddForce(direction * speed * (Time.deltaTime * 100), ForceMode2D.Force);
    }
}

using UnityEngine;
using MyGame.Interfaces;
public class MoveBetweenTwoPoints : MonoBehaviour, IMoveBetweenTwoVector2
{
    [SerializeField] private float speed;
    Rigidbody2D rb => GetComponent<Rigidbody2D>();

    Vector2 pos1, pos2;
    Vector2 activePos;

    public void SetStartingAndEndPos(Vector2 start, Vector2 end) {
        pos1 = start;
        pos2 = end;
        activePos = pos1;
    }

    public void CheckIfOnPos() {
        float proximityThreshold = .1f;

        if (Vector2.Distance(transform.position, activePos) > proximityThreshold) return;

        activePos = (activePos == pos1) ? pos2 : pos1;
    }

    public void MoveBetween() {
        Vector2 direction = (activePos - (Vector2)transform.position).normalized;
        rb.AddForce(direction * speed * (Time.deltaTime * 100), ForceMode2D.Force);
    }

    public Vector2 ReturnActiveDir() => activePos;
}

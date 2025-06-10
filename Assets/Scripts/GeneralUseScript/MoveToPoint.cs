using UnityEngine;

public class MoveToPoint : MonoBehaviour, IMoveTo 
{
    [SerializeField] private float moveSpeed = 5f;
    Vector2 targetPos;
    Rigidbody2D rb => GetComponent<Rigidbody2D>();

    public void MoveToTarget(Vector2 target) {
        targetPos = target;

        // Calculate direction
        Vector2 direction = (targetPos - rb.position).normalized;

        // Apply force
        rb.AddForce(direction * moveSpeed * Time.deltaTime, ForceMode2D.Force);
    }

    public bool CheckIfOnTarget() {
        float threshold = 0.1f;
        return Vector2.Distance(rb.position, targetPos) <= threshold;
    }
}

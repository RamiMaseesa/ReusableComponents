using UnityEngine;

public class DirectionOfTrapArrow : MonoBehaviour, IDirection {
    [SerializeField] private float angleVariationDegrees = 10f; // maximum angle variation

    public Vector2 GenerateDirection() {
        Vector2 from = transform.position;
        Vector2 center = Camera.main.ViewportToWorldPoint(new Vector2(0.5f, 0.5f));

        // Direction pointing toward the center
        Vector2 direction = (center - from).normalized;

        // Convert direction to angle
        float baseAngle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        // Apply random variation
        float randomAngle = Random.Range(-angleVariationDegrees, angleVariationDegrees);
        float finalAngle = baseAngle + randomAngle;

        // Convert angle back to vector
        Vector2 variedDirection = new Vector2(
            Mathf.Cos(finalAngle * Mathf.Deg2Rad),
            Mathf.Sin(finalAngle * Mathf.Deg2Rad)
        ).normalized;

        return variedDirection;
    }
}

using UnityEngine;

public class Helper : MonoBehaviour {
    public Quaternion PointAtDirection(Vector2 direction) {
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        angle -= 90f;
        return Quaternion.Euler(0, 0, angle);
    }
}

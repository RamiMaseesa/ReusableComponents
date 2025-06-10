using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipObject : MonoBehaviour, IFlip {
    public void FlipThis(Vector2 direction) {
        if (direction.x < 0f) {
            transform.rotation = Quaternion.Euler(0, 180, 0);
        } else if (direction.x > 0f) {
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
    }
}

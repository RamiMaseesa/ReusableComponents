using UnityEngine;

public class DirectionOfTrapSaw : MonoBehaviour, IDirection {
    public Vector2 GenerateDirection() {

        Camera cam = Camera.main;
        Vector2 min = cam.ViewportToWorldPoint(new Vector2(0, 0));
        Vector2 max = cam.ViewportToWorldPoint(new Vector2(1, 1));

        // Choose a random point within the screen bounds
        float x = Random.Range(min.x, max.x);
        float y = Random.Range(min.y, max.y);

        Vector2 direction = new Vector2(x, y);

        return direction;
    }
}

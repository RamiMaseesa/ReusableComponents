using UnityEngine;
using MyGame.Interfaces;
public class InputForKeys : MonoBehaviour, IInput {
    public Vector2 GetInputDirection() {

        float horizontal = 0f;
        float vertical = 0f;

        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)) {
            vertical += 1f;
        }
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow)) {
            vertical -= 1f;
        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)) {
            horizontal -= 1f;
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)) {
            horizontal += 1f;
        }

        return new Vector2(horizontal, vertical).normalized;
    }

    public bool WantsToDash() {
        return Input.GetKeyDown(KeyCode.Space);
    }
}

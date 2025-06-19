using UnityEngine;
using MyGame.Interfaces;
public class InputForController : MonoBehaviour, IInput {
    public Vector2 GetInputDirection() {

        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        return new Vector2(horizontal, vertical).normalized;
    }

    public bool WantsToDash() {
        return Input.GetButtonDown("Fire3");
    }
}

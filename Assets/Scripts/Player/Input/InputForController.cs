using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

using UnityEngine;

namespace MyGame.Interfaces {
    public interface IInput {
        Vector2 GetInputDirection();

        bool WantsToDash();
    }
}
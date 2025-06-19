using UnityEngine;
namespace MyGame.Interfaces {
    public interface IMoveTo {
        void MoveToTarget(Vector2 target);
        bool CheckIfOnTarget();
    }
}
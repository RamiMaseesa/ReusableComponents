using UnityEngine;

public interface IMoveTo{
    void MoveToTarget(Vector2 target);
    bool CheckIfOnTarget();
}

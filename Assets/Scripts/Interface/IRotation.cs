using Unity.Mathematics;
using UnityEngine;

public interface IRotation
{
    public float GetRotation();

    public void SetRotation(float rotation);

    public bool IsRotating();

    public bool CompletedRotation();
}

using Unity.Mathematics;
using UnityEngine;
namespace MyGame.Interfaces {
    public interface IRotation {
        public float GetRotation();

        public void SetRotation(float rotation);

        public bool IsRotating();

        public bool CompletedRotation();
    }
}
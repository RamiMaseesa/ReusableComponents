using UnityEngine;
namespace MyGame.Interfaces {
    public interface IMoveBetweenTwoVector2 {
        public void SetStartingAndEndPos(Vector2 start, Vector2 end);

        public void CheckIfOnPos();

        public void MoveBetween();

        public Vector2 ReturnActiveDir();
    }
}
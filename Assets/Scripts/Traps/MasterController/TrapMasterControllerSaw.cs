using UnityEngine;

public class TrapMasterControllerSaw : MonoBehaviour
{
    ILifeTime lifeTime;
    IDirection direction;
    IMoveBetweenTwoVector2 moveBetweenTwoVector2;

    Vector2 dir1, dir2;

    void Start() {
        lifeTime = GetComponent<ILifeTime>();
        direction = GetComponent<IDirection>();
        moveBetweenTwoVector2 = GetComponent<IMoveBetweenTwoVector2>();

        dir1 = direction.GenerateDirection();
        dir2 = direction.GenerateDirection();
        lifeTime.SetLifeTime(60);
        moveBetweenTwoVector2.SetStartingAndEndPos(dir1, dir2);
    }

    // Update is called once per frame
    void Update() {
        moveBetweenTwoVector2.MoveBetween();
        moveBetweenTwoVector2.CheckIfOnPos();
        if (lifeTime.CheckLifeTimeOver()) Destroy(gameObject);
    }
}

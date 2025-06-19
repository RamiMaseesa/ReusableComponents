using MyGame.Interfaces;
using UnityEngine;

public class HeartMasterController : MonoBehaviour
{
    ILifeTime lifeTime;
    IDirection direction;
    IMoveBetweenTwoVector2 moveBetweenTwoVector2;
    IPickUp pickUp;
    IPickUpAction action;

    Vector2 dir1, dir2;

    void Start()
    {
        lifeTime = GetComponent<ILifeTime>();
        direction = GetComponent<IDirection>();
        moveBetweenTwoVector2 = GetComponent<IMoveBetweenTwoVector2>();
        pickUp = GetComponent<PickUpComp>();
        action = GetComponent<IPickUpAction>();

        dir1 = direction.GenerateDirection();
        dir2 = direction.GenerateDirection();
        lifeTime.SetLifeTime(5);
        moveBetweenTwoVector2.SetStartingAndEndPos(dir1, dir2);
    }

    // Update is called once per frame
    void Update()
    {
        moveBetweenTwoVector2.MoveBetween();
        moveBetweenTwoVector2.CheckIfOnPos();
        if (lifeTime.CheckLifeTimeOver()) Destroy(gameObject);

        if (pickUp.Colliding()) action.Action();
    }
}

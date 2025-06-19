using MyGame.Interfaces;
using UnityEngine;
using UnityEngine.Windows;

public class ShieldMasterController : MonoBehaviour
{
    ILifeTime lifeTime;
    IDirection direction;
    IMoveBetweenTwoVector2 moveBetweenTwoVector2;
    IPickUp pickUp;
    IPickUpAction action;
    IDash dash;

    private TimerComp timer;
    Vector2 dir1, dir2;

    void Start()
    {
        lifeTime = GetComponent<ILifeTime>();
        direction = GetComponent<IDirection>();
        moveBetweenTwoVector2 = GetComponent<IMoveBetweenTwoVector2>();
        pickUp = GetComponent<PickUpComp>();
        action = GetComponent<IPickUpAction>();
        dash = GetComponent<IDash>();
        timer = FindFirstObjectByType<TimerComp>();
        timer.StartTimer("dash" + gameObject.name, 1);

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

        if (timer.TimerCheck("dash" + gameObject.name)) {

            dash.DashForward(moveBetweenTwoVector2.ReturnActiveDir());
            timer.StartTimer("dash" + gameObject.name, 1);
        }
    }
}

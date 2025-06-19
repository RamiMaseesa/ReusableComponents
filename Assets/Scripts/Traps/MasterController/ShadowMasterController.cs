using MyGame.Interfaces;
using UnityEngine;
using UnityEngine.Windows;

public class ShadowMasterController : MonoBehaviour
{
    ILifeTime lifeTime;
    IDirection direction;
    IDash dash;
    IMove move;
    IFlip flip;

    private TimerComp timer;
    void Start()
    {
        lifeTime = GetComponent<ILifeTime>();
        direction = GetComponent<IDirection>();
        dash = GetComponent<IDash>();
        move = GetComponent<IMove>();
        flip = GetComponent<IFlip>();

        timer = FindFirstObjectByType<TimerComp>();
        timer.StartTimer("dashShadow", 1);
        lifeTime.SetLifeTime(40);
    }

    // Update is called once per frame
    void Update()
    {

        move.MoveToDirection2D(direction.GenerateDirection());
        flip.FlipThis(direction.GenerateDirection());
        if (timer.TimerCheck("dashShadow")) {

            dash.DashForward(direction.GenerateDirection());
            timer.StartTimer("dashShadow", 1);
        }

        if (lifeTime.CheckLifeTimeOver()) Destroy(gameObject);
    }
}

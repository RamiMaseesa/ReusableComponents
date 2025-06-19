using MyGame.Interfaces;
using UnityEngine;

public class FireMasterController : MonoBehaviour
{
    ILifeTime lifeTime;
    IDirection direction;
    IMove move;

    void Start() {
        lifeTime = GetComponent<ILifeTime>();
        direction = GetComponent<IDirection>();
        move = GetComponent<IMove>();

        lifeTime.SetLifeTime(20);
    }

    // Update is called once per frame
    void Update() {

        move.MoveToDirection2D(direction.GenerateDirection());

        if (lifeTime.CheckLifeTimeOver()) Destroy(gameObject);
    }
}

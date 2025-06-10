using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapMasterControllerArrow : MonoBehaviour {
    ILifeTime lifeTime;
    IDirection direction;
    IMove move;

    Vector2 dir;

    void Start() {
        lifeTime = GetComponent<ILifeTime>();
        direction = GetComponent<IDirection>();
        move = GetComponent<IMove>();

        dir = direction.GenerateDirection();
        lifeTime.SetLifeTime(7);
        transform.rotation = FindAnyObjectByType<Helper>().PointAtDirection(dir);
    }

    // Update is called once per frame
    void Update() {
        move.MoveToDirection2D(dir);
            
        if (lifeTime.CheckLifeTimeOver()) Destroy(gameObject);
    }
}

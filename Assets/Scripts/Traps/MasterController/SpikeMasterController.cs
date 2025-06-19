using UnityEngine;
using MyGame.Interfaces;

public class SpikeMasterController : MonoBehaviour
{
    ILifeTime lifeTime;
    void Start()
    {
        lifeTime = GetComponent<ILifeTime>();
        lifeTime.SetLifeTime(60);
    }

    // Update is called once per frame
    void Update()
    {
        if (lifeTime.CheckLifeTimeOver()) Destroy(gameObject);
    }
}

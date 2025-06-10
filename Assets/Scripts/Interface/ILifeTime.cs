using UnityEngine;

public interface ILifeTime
{
    void SetLifeTime(float lifeTime);

    bool CheckLifeTimeOver();
}

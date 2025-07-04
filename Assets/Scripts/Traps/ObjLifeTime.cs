using UnityEngine;
using MyGame.Interfaces;
public class ObjLifeTime : MonoBehaviour, ILifeTime {

    private float lifeTimeLeft;

    public bool CheckLifeTimeOver() {
        if (lifeTimeLeft < Time.time) return true;
        return false;
    }

    public void SetLifeTime(float lifeTime) {
        lifeTimeLeft = Time.time + lifeTime;
    }
}

using UnityEngine;
using MyGame.Interfaces;
public class SpawnAroundMap : MonoBehaviour, ISpawn {
    [SerializeField] private float diameter = 25f;

    public Vector2 SpawnObj() {
        float radius = diameter / 2f;
        Vector2 center = Vector2.zero;

        float angleDegrees = Random.Range(0f, 360f); // random angle each time
        float angleRad = angleDegrees * Mathf.Deg2Rad;

        Vector2 spawnPos = center + new Vector2(Mathf.Cos(angleRad), Mathf.Sin(angleRad)) * radius;

        return spawnPos;
    }
}

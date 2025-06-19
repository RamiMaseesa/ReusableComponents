using MyGame.Interfaces;
using UnityEngine;

public class PlayerDirection : MonoBehaviour, IDirection {

    public Vector2 GenerateDirection() {
        GameObject player = FindFirstObjectByType<PlayerMasterController>()?.gameObject;
        if (player == null) return Vector2.zero;

        Vector2 direction = (player.transform.position - transform.position).normalized;
        return direction;
    }
}
using MyGame.Interfaces;
using UnityEditor;
using UnityEngine;

public class SpawnRandomOnMap : MonoBehaviour, ISpawn
{

    public Vector2 SpawnObj() {
        Camera cam = Camera.main;

        // Get the screen bounds in world units
        Vector2 bottomLeft = cam.ViewportToWorldPoint(new Vector3(0, 0, 0));
        Vector2 topRight = cam.ViewportToWorldPoint(new Vector3(1, 1, 0));

        // Random X and Y within visible camera area
        float randX = Random.Range(bottomLeft.x, topRight.x);
        float randY = Random.Range(bottomLeft.y, topRight.y);

        return new Vector2(randX, randY);
    }
}

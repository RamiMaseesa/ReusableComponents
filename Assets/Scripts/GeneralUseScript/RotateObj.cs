using System.Collections;
using UnityEngine;
using MyGame.Interfaces;
public class RotateObj : MonoBehaviour, IRotation {

    public bool rotating = false;
    private float completedRotation;

    public float GetRotation() {
        // Randomly pick a multiple of 45°: 45, 90, 135, 180
        return Random.Range(1, 5) * 45f;
    }

    public void SetRotation(float rotation) {
        if (rotating) return;
        completedRotation = NormalizeAngle(transform.eulerAngles.z + rotation);
        rotating = true;
        // Start coroutine to handle smooth rotation
        StartCoroutine(RotateToAngle(completedRotation));
    }

    public bool IsRotating() {
        return rotating;
    }

    public bool CompletedRotation() {
        return !rotating;
    }

    private IEnumerator RotateToAngle(float targetAngle) {
        float speed = 90f; // degrees per second
        float currentZ = transform.eulerAngles.z;

        while (Mathf.Abs(Mathf.DeltaAngle(currentZ, targetAngle)) > 0.5f) {
            currentZ = Mathf.MoveTowardsAngle(currentZ, targetAngle, speed * Time.deltaTime);
            transform.rotation = Quaternion.Euler(0f, 0f, currentZ);
            yield return null;
        }

        transform.rotation = Quaternion.Euler(0f, 0f, targetAngle);
        rotating = false;
    }

    private float NormalizeAngle(float angle) {
        return (angle + 360f) % 360f;
    }

}

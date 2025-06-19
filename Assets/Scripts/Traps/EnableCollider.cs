using UnityEngine;

public class EnableCollider : MonoBehaviour
{
    private BoxCollider2D boxCollider;
    private Renderer objRenderer;
    private bool hasBeenEnabled = false;

    void Awake() {
        boxCollider = GetComponent<BoxCollider2D>();
        objRenderer = GetComponent<Renderer>();

        boxCollider.enabled = false; // Start disabled
    }

    void Update() {
        if (!hasBeenEnabled && objRenderer.isVisible) {
            boxCollider.enabled = true;
            hasBeenEnabled = true; // Only enable once
        }
    }
}

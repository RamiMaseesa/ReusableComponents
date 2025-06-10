using Unity.VisualScripting;
using UnityEngine;

public class Dash : MonoBehaviour, IDash {

    [SerializeField] private float dashSpeed;

    Rigidbody2D rb => GetComponent<Rigidbody2D>();

    public void DashForward(Vector2 direction) {

        rb.linearVelocity = new Vector2(.0f, .0f);

        rb.AddForce(direction * dashSpeed * 5, ForceMode2D.Impulse);
    }
}

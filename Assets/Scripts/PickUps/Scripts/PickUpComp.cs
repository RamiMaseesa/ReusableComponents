using MyGame.Interfaces;
using UnityEngine;

public class PickUpComp : MonoBehaviour, IPickUp
{
    private bool hitPlayer = false;
    public bool Colliding() {
        return hitPlayer;
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.gameObject.GetComponent<PlayerMasterController>() != null) {
            hitPlayer = true;
        }
    }

}

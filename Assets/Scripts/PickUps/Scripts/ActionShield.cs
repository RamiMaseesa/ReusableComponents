using UnityEngine;

public class ActionShield : MonoBehaviour, IPickUpAction
{
    GameObject player;

    public void Action() {
        player = FindFirstObjectByType<PlayerMasterController>().gameObject;

        player.GetComponent<PlayerHealth>().ActivateTemporaryImmunity();
        Destroy(gameObject);
    }
}

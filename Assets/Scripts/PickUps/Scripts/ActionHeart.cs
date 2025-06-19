using UnityEngine;

public class ActionHeart : MonoBehaviour, IPickUpAction {

    GameObject player;

    public void Action() {
        player = FindFirstObjectByType<PlayerMasterController>().gameObject;

        player.GetComponent<PlayerHealth>().AddHealthPoint();
        Destroy(gameObject);
    }
}

using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Windows;

public class ChangePlayerControll : MonoBehaviour
{
    PlayerMasterController player;
    void Start()
    {
        player = FindFirstObjectByType<PlayerMasterController>();
    }

    public void OnButtonSwitchPlayerController() {
        if (player.GetComponent<InputForController>() != null) {
            StartCoroutine(SwitchInput<InputForController, InputForKeys>());
        } else if (player.GetComponent<InputForKeys>() != null) {
            StartCoroutine(SwitchInput<InputForKeys, InputForController>());
        }
    }

    IEnumerator SwitchInput<TRemove, TAdd>() where TRemove : Component where TAdd : Component {
        Destroy(player.GetComponent<TRemove>());
        yield return null; // Wait 1 frame for the removal
        player.gameObject.AddComponent<TAdd>();
        player.input = (IInput)player.GetComponent<TAdd>();
    }
}

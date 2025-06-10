using TMPro;
using UnityEngine;

public class ShowSurvivedTime : MonoBehaviour
{
    TMP_Text Text;
    private void Start() {
        Text = GetComponent<TMP_Text>();

        int minutes = PlayerPrefs.GetInt("minutes");
        int seconds = PlayerPrefs.GetInt("seconds");

        Text.text = $"{minutes} min {seconds} sec";
    }
}

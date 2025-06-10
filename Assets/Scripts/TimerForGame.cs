using TMPro;
using UnityEngine;

public class TimerForGame : MonoBehaviour
{
    private TimerComp timer;
    private TMP_Text text;

    int minutes;
    int seconds;
    float time;
    void Start()
    {
        timer = FindFirstObjectByType<TimerComp>();
        text = GetComponent<TMP_Text>();

        timer.StartTimer("game", 120);
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

        minutes = Mathf.FloorToInt(time / 60f);
        seconds = Mathf.FloorToInt(time % 60f);

        text.text = $"{minutes} min {seconds} sec";

        if (timer.TimerCheck("game")) GameEnd.Instance.TriggerWin();
    }

    public void SaveData() {
        PlayerPrefs.SetInt("minutes", minutes);
        PlayerPrefs.SetInt("seconds", seconds);
    }
}

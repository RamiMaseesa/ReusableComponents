using UnityEngine;

public class GameEnd : MonoBehaviour
{
    public delegate void GameEvent();
    public event GameEvent LoseEvent = delegate { };
    public event GameEvent WinEvent = delegate { };

    public static GameEnd Instance { get; private set; }

    private void Awake() {
        // If there is an instance, and it's not me, delete myself.

        if (Instance != null && Instance != this) {
            Destroy(this);
        } else {
            Instance = this;
        }
    }


    private void Start() {
        TimerForGame timerForGame = FindFirstObjectByType<TimerForGame>();
        SceneManager sceneManager = FindFirstObjectByType<SceneManager>();

        LoseEvent += timerForGame.SaveData;
        LoseEvent += () => sceneManager.MoveThisAmountForward(2);

        WinEvent += timerForGame.SaveData;
        WinEvent += () => sceneManager.MoveThisAmountForward(1);

    }

    public void TriggerWin() {
        WinEvent?.Invoke();
    }

    public void TriggerLoss() {
        LoseEvent?.Invoke();
    }
}

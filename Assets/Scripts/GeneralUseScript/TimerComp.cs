using System.Collections.Generic;
using UnityEngine;

public class TimerComp : MonoBehaviour {
    private Dictionary<string, float> timers = new Dictionary<string, float>();

    // Start or reset a timer
    public void StartTimer(string key, float duration) {
        timers[key] = Time.time + duration;
    }

    // Check if timer has expired
    public bool TimerCheck(string key) {
        if (!timers.ContainsKey(key)) return false;

        return Time.time >= timers[key];
    }

}

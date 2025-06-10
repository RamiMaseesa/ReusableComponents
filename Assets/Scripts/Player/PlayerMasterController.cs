using UnityEngine;

public class PlayerMasterController : MonoBehaviour {
    public IInput input;
    private IMove move;
    private IFlip flip;
    private IAnimate animate;
    private IDash dash;
    private IHealth health;

    private TimerComp timer;

    void Awake() {
        input = GetComponent<IInput>();
        move = GetComponent<IMove>();
        flip = GetComponent<IFlip>();
        animate = GetComponent<IAnimate>();
        dash = GetComponent<IDash>();
        health = GetComponent<IHealth>();

        timer = FindFirstObjectByType<TimerComp>();
        timer.StartTimer("dash", 0);
        health.GenerateHearts();
    }

    void Update() {

        Vector2 direction = input.GetInputDirection();

        // move player
        move.MoveToDirection2D(direction);
        // flip sprite
        flip.FlipThis(direction);
        // animate player
        animate.AnimationValues(direction);

        // dash
        if (input.WantsToDash() && timer.TimerCheck("dash")) {

            dash.DashForward(direction);
            timer.StartTimer("dash", 1);
        }

    }
}

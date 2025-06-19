using UnityEngine;
using MyGame.Interfaces;
public class AnimationForPlayer : MonoBehaviour, IAnimate {

    Animator animator => GetComponent<Animator>();

    public void AnimationValues(Vector2 direction) {

        bool walking = true;
        if (direction.y == 0 && direction.x == 0) walking = false;

        animator.SetBool("Walking", walking);
    }
}

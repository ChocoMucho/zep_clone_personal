using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : Animations
{
    private void Start()
    {
        controller.OnMoveEvent += MoveAnimation;
    }

    public void MoveAnimation(Vector2 direction)
    {
        animator.SetBool("IsRun", direction.magnitude > 0f);
    }
}

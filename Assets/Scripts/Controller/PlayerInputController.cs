using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputController : CharacterController
{
    private Camera camera;

    private void Awake()
    {
        camera = Camera.main;
    }

    public void OnMove(InputValue value)
    {
        CallMoveEvent(value.Get<Vector2>().normalized);
    }

    public void OnLook(InputValue value)
    {
        Vector2 newAim = value.Get<Vector2>();
        Vector2 mousePos = camera.ScreenToWorldPoint(newAim);

        //방향 벡터 구하기
        newAim = (mousePos - (Vector2)transform.position).normalized;

        if (newAim.magnitude > .9f)
            CallLookEvent(newAim);
    }

}

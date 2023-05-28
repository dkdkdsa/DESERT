using Enum;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerEventSystem : MonoBehaviour
{

    public event Action<InteractionClickKey> OnInteractionClickKeyEvent;
    public event Action<float> OnHorizontalAxisEvent;
    public event Action<float> OnVerticalAxisEvent;
    public event Action<float> OnMouseXEvent;
    public event Action<float> OnMouseYEvent;
    public event Action OnJumpKeyPressEvent;
    public event Action OnFixedUpdateEvent;
    public event Action OnUpdateEvent;

    private void Update()
    {
        
        JumpEventExecute();
        InteractionEventExecute();
        OnUpdateEvent?.Invoke();

    }

    private void FixedUpdate()
    {

        OnHorizontalAxisEvent?.Invoke(Input.GetAxisRaw("Horizontal"));
        OnVerticalAxisEvent?.Invoke(Input.GetAxisRaw("Vertical"));
        OnMouseXEvent?.Invoke(Input.GetAxisRaw("Mouse X"));
        OnMouseYEvent?.Invoke(Input.GetAxisRaw("Mouse Y"));
        OnFixedUpdateEvent?.Invoke();

    }

    private void JumpEventExecute()
    {

        if (Input.GetKeyDown(KeyCode.Space)) OnJumpKeyPressEvent?.Invoke();

    }

    private void InteractionEventExecute()
    {

        //Left
        if (Input.GetMouseButton(0))
        {

            OnInteractionClickKeyEvent?.Invoke(InteractionClickKey.Left);

        }
        else if(Input.GetMouseButton(1)) //right
        {

            OnInteractionClickKeyEvent?.Invoke(InteractionClickKey.Right);

        }

    }

}

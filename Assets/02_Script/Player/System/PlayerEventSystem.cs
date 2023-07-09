using Enums;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerEventSystem : MonoBehaviour
{

    public event Action<InteractionClickKey> OnInteractionClickKeyPressEvent;
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
        if (Input.GetKeyDown(KeyCode.Escape)) SceneManager.LoadScene("IntroRM");

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

        if (Input.GetMouseButtonDown(0))
        {

            OnInteractionClickKeyPressEvent?.Invoke(InteractionClickKey.Left);

        }
        else if(Input.GetMouseButtonDown(1)) 
        {

            OnInteractionClickKeyPressEvent?.Invoke(InteractionClickKey.Right);

        }

    }

}

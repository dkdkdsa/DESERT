using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerEventSystem : MonoBehaviour
{

    public event Action<float> OnHorizontalAxisEvent;
    public event Action<float> OnVerticalAxisEvent;
    public event Action OnJumpKeyPressEvent;

    private void FixedUpdate()
    {

        OnHorizontalAxisEvent?.Invoke(Input.GetAxisRaw("Horizontal"));
        OnHorizontalAxisEvent?.Invoke(Input.GetAxisRaw("Vertical"));

    }

}

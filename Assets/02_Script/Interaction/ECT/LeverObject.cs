using Enums;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class LeverObject : InteractionObjectRoot
{

    [SerializeField] private UnityEvent leverDownEvent;

    private bool isClick = false;

    public override void OnCursorClickEvent(InteractionClickKey key)
    {

        if (isClick) return;

        isClick = true;
        leverDownEvent?.Invoke();

    }

    public override void OnCursorOnEvent()
    {

        //UI 추가 예정

    }
}

using Enums;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapChangeObject : InteractionObjectRoot
{

    [SerializeField] private CircleDissolveEvent dissolveEvent;

    public override void OnCursorClickEvent(InteractionClickKey key)
    {

        if(key == InteractionClickKey.Left)
        {

            dissolveEvent.StartEvent();

        }

    }

    public override void OnCursorOnEvent()
    {

        //UI추가 예정

    }
}

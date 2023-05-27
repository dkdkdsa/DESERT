using Interface;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PlayerBehaviorRoot : PlayerRoot, IEventObject
{

    protected PlayerEventSystem eventSystem;

    protected override void Awake()
    {

        base.Awake();

        eventSystem = GetComponent<PlayerEventSystem>();

        AddEvent();

    }

    public abstract void AddEvent();
    public abstract void RemoveEvent();

}

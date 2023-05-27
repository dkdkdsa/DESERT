using Interface;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PlayerBehaviorRoot : PlayerRoot, IEventObject
{

    protected override void Awake()
    {

        base.Awake();

        AddEvent();

    }

    public abstract void AddEvent();
    public abstract void RemoveEvent();

}

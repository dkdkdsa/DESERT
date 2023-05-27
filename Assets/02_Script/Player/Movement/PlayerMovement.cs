using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : PlayerBehaviorRoot
{

    private float horInput, verInput;

    private void SetHor(float v) { horInput = v; }
    private void SetVer(float v) { verInput = v; }

    public override void AddEvent()
    {

        eventSystem.OnHorizontalAxisEvent += SetHor;
        eventSystem.OnVerticalAxisEvent += SetVer;

    }

    public override void RemoveEvent()
    {

        eventSystem.OnHorizontalAxisEvent -= SetHor;
        eventSystem.OnVerticalAxisEvent -= SetVer;

    }
}

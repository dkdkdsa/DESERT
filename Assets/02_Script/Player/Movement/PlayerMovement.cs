using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : PlayerBehaviorRoot
{

    private float horInput, verInput;

    private void Move()
    {

        var xVec = transform.forward * verInput;
        var yVec = transform.right * horInput;

        var targetVec = (xVec + yVec).normalized * valueSystem.moveSpeed;
        targetVec.y = rigid.velocity.y;

        rigid.velocity = targetVec;

    }

    private void SetHor(float v) { horInput = v; }
    private void SetVer(float v) { verInput = v; }

    public override void AddEvent()
    {

        eventSystem.OnHorizontalAxisEvent += SetHor;
        eventSystem.OnVerticalAxisEvent += SetVer;
        eventSystem.OnFixedUpdateEvent += Move;

    }

    public override void RemoveEvent()
    {

        eventSystem.OnHorizontalAxisEvent -= SetHor;
        eventSystem.OnVerticalAxisEvent -= SetVer;
        eventSystem.OnFixedUpdateEvent -= Move;

    }
}

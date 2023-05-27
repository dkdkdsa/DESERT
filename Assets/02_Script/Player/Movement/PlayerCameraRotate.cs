using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCameraRotate : PlayerBehaviorRoot
{

    private float xInput, yInput;



    private void SetX(float v) { xInput = v; }
    private void SetY(float v) { yInput = v; }

    public override void AddEvent()
    {

        eventSystem.OnMouseXEvent += SetX;
        eventSystem.OnMouseYEvent -= SetY;

    }

    public override void RemoveEvent()
    {

        eventSystem.OnMouseXEvent -= SetX;
        eventSystem.OnMouseYEvent -= SetY;
    }
}

using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCameraRotate : PlayerBehaviorRoot
{

    private CinemachineVirtualCamera cvcam;
    private float xValue, yValue;
    private float xInput, yInput;

    protected override void Awake()
    {

        base.Awake();
        
        cvcam = FindObjectOfType<CinemachineVirtualCamera>();

    }

    private void CameraRotate()
    {

        xValue += xInput * Time.fixedDeltaTime;
        yValue += yInput * Time.fixedDeltaTime;

    }

    private void SetX(float v) { xInput = v; }
    private void SetY(float v) { yInput = v; }

    public override void AddEvent()
    {

        eventSystem.OnMouseXEvent += SetX;
        eventSystem.OnMouseYEvent += SetY;
        eventSystem.OnFixedUpdateEvent += CameraRotate;

    }

    public override void RemoveEvent()
    {

        eventSystem.OnMouseXEvent -= SetX;
        eventSystem.OnMouseYEvent -= SetY;
        eventSystem.OnFixedUpdateEvent -= CameraRotate;

    }
}

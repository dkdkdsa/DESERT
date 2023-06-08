using Enums;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction : PlayerBehaviorRoot
{

    private Camera cam;

    protected override void Awake()
    {

        base.Awake();

        cam = Camera.main;

    }

    private void InteractionOn()
    {

        var ray = cam.ScreenPointToRay(new Vector2((cam.pixelWidth - 1) / 2, (cam.pixelHeight - 1) / 2));
        if (Physics.Raycast(ray, out var hit, 30, valueSystem.interactionMask))
        {



        }

    }

    private void InteractionClick(InteractionClickKey key)
    {
        var ray = cam.ScreenPointToRay(new Vector2((cam.pixelWidth - 1) / 2, (cam.pixelHeight - 1) / 2));
        if(Physics.Raycast(ray, out var hit, 30, valueSystem.interactionMask))
        {
            


        }

    }

    public override void AddEvent()
    {

        eventSystem.OnInteractionClickKeyPressEvent += InteractionClick;
        eventSystem.OnUpdateEvent += InteractionOn;

    }

    public override void RemoveEvent()
    {

        eventSystem.OnInteractionClickKeyPressEvent -= InteractionClick;
        eventSystem.OnUpdateEvent -= InteractionOn;

    }
}

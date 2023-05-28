using Enum;
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

    private void Interaction(InteractionClickKey key)
    {
        var ray = cam.ScreenPointToRay(new Vector2((cam.pixelWidth - 1) / 2, (cam.pixelHeight - 1) / 2));
        if(Physics.Raycast(ray, out var hit, valueSystem.interactionMask))
        {

            if(hit.transform.TryGetComponent<PuzzleObjectRoot>(out var puzzle))
            {

                puzzle.InteractionEvent(key);

            }

        }

    }

    public override void AddEvent()
    {

        eventSystem.OnInteractionClickKeyEvent += Interaction;

    }

    public override void RemoveEvent()
    {

        eventSystem.OnInteractionClickKeyEvent -= Interaction;

    }
}

using Enums;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Lever : InteractionObjectRoot
{

    [SerializeField] private UnityEvent interactionEvt;

    private LeverAnimator animator;
    private bool isInteraction;

    private void Awake()
    {
        
        animator = GetComponentInChildren<LeverAnimator>();

    }

    public override void OnCursorClickEvent(InteractionClickKey key)
    {

        if (!isInteraction && key == InteractionClickKey.Left)
        {

            isInteraction = true;

        }

    }

    public override void OnCursorOnEvent()
    {



    }
}

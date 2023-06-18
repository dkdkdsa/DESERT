using Enums;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever : InteractionObjectRoot
{

    private LeverAnimator animator;
    private bool isInteraction;

    private void Awake()
    {
        
        animator = GetComponentInChildren<LeverAnimator>();

    }

    public override void OnCursorClickEvent(InteractionClickKey key)
    {



    }

    public override void OnCursorOnEvent()
    {



    }
}

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
            interactionEvt?.Invoke();
            animator.SetLeverUpHash();

        }

    }

    public override void OnCursorOnEvent()
    {

        UIManager.instance.GetUIObject<TextSetting>("SettingText").SetText("우클릭으로 레버 작동");

    }
}

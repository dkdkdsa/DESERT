using Enums;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Lever : InteractionObjectRoot
{

    [SerializeField] private UnityEvent interactionEvt;

    private LeverAnimator animator;
    private Transform playerTrm;
    private bool isInteraction;

    private void Awake()
    {
        
        animator = GetComponentInChildren<LeverAnimator>();
        playerTrm = GameObject.Find("Player").transform;

    }

    public override void OnCursorClickEvent(InteractionClickKey key)
    {

        if (Vector3.Distance(transform.position, playerTrm.position) > 5) return;

        if (!isInteraction && key == InteractionClickKey.Left)
        {

            isInteraction = true;
            interactionEvt?.Invoke();
            animator.SetLeverUpHash();

        }

    }

    public override void OnCursorOnEvent()
    {

        if (Vector3.Distance(transform.position, playerTrm.position) > 5) return;

        UIManager.instance.GetUIObject<TextSetting>("SettingText").SetText("좌클릭으로 레버 작동");

    }
}

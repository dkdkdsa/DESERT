using Enums;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FD.Dev;

public class MapChangeObject : InteractionObjectRoot
{

    [SerializeField] private CircleDissolveEvent dissolveEvent;
    

    private bool isChageCoolDown = false;
    private PlayerValueSystem valueSystem;
    private Transform playerTrm;

    private void Awake()
    {
        
        valueSystem = FindObjectOfType<PlayerValueSystem>();
        playerTrm = GameObject.Find("Player").transform;

    }

    public override void OnCursorClickEvent(InteractionClickKey key)
    {

        if (Vector3.Distance(transform.position, playerTrm.position) > 5) return;

        if(key == InteractionClickKey.Left && !isChageCoolDown)
        {

            valueSystem.mapChangeSound.Play();
            isChageCoolDown = true;
            dissolveEvent.StartEvent();

            FAED.DelayInvoke(() =>
            {

                isChageCoolDown = false;

            }, 2f);

        }

    }

    public override void OnCursorOnEvent()
    {
        if (Vector3.Distance(transform.position, playerTrm.position) > 5) return;
        UIManager.instance.GetUIObject<TextSetting>("SettingText").SetText("좌클릭으로 석상 작동");

    }


}

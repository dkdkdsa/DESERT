using Enums;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FD.Dev;

public class MapChangeObject : InteractionObjectRoot
{

    [SerializeField] private CircleDissolveEvent dissolveEvent;
    

    private bool isChageCoolDown = false;

    public override void OnCursorClickEvent(InteractionClickKey key)
    {

        if(key == InteractionClickKey.Left && !isChageCoolDown)
        {

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

        UIManager.instance.GetUIObject<TextSetting>("SettingText").SetText("우클릭으로 석상 작동");

    }


}

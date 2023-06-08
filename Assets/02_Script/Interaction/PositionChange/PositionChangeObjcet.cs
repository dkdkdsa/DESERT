using Enums;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionChangeObjcet : InteractionObjectRoot
{

    private Transform playerTrm;

    private void Awake()
    {

        playerTrm = GameObject.Find("Player").transform;

    }

    public override void OnCursorClickEvent(InteractionClickKey key)
    {

        if(key == InteractionClickKey.Left)
        {



        }

    }

    public override void OnCursorOnEvent()
    {

        //나중에 UI 추가 예정

    }

}

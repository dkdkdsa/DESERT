using Enums;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionChangeObjcet : InteractionObjectRoot
{

    [SerializeField] private float sencingRange = 5;
    private Transform playerTrm;

    private void Awake()
    {

        playerTrm = GameObject.Find("Player").transform;

    }

    public override void OnCursorClickEvent(InteractionClickKey key)
    {

        if(key == InteractionClickKey.Left && Vector3.Distance(transform.position, playerTrm.position) <= sencingRange)
        {

            var curTrm = transform.position;
            var rutTrm = playerTrm.position;

            transform.position = rutTrm;
            playerTrm.position = curTrm;

        }

    }

    public override void OnCursorOnEvent()
    {

        if (Vector3.Distance(transform.position, playerTrm.position) > sencingRange) return;

    }

}

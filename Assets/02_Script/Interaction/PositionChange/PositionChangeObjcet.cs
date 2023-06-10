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



        }

    }

    public override void OnCursorOnEvent()
    {

        if (Vector3.Distance(transform.position, playerTrm.position) > sencingRange) return;

    }

    private void ChangePosition()
    {

        var curTrm = transform.position;
        var rutTrm = playerTrm.position;

        transform.position = rutTrm;
        playerTrm.position = curTrm;

    }

    private IEnumerator PosChangeCo()
    {

        yield return null;




    }

}

using Enums;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowObject : PuzzleObjectRoot
{

    private Transform followObjectTrm;

    protected virtual void Awake()
    {

        followObjectTrm = GameObject.Find("Player").transform.Find("FollowTrm");

    }


    public override void InteractionEvent(InteractionClickKey type)
    {

        

    }
}

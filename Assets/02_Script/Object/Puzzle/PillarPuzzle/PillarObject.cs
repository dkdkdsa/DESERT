using Enum;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PillarObject : PuzzleObjectRoot
{
    public override void InteractionEvent(InteractionClickKey type)
    {
        
        if(type == InteractionClickKey.Left) 
        {

            transform.eulerAngles -= new Vector3(0, 10, 0) * Time.deltaTime;

        }
        else
        {

            transform.eulerAngles += new Vector3(0, 10, 0) * Time.deltaTime;

        }

    }
}

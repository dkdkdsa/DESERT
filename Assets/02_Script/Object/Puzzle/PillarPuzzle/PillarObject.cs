using Enums;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PillarObject : PuzzleObjectRoot
{

    private float rotateSpeed = 1f;

    public void SettingRotateSpeed(float speed)
    {

        rotateSpeed = speed;

    }

    public override void InteractionEvent(InteractionClickKey type)
    {
        
        if(type == InteractionClickKey.Left) 
        {

            transform.eulerAngles -= new Vector3(0, 10, 0) * Time.deltaTime * rotateSpeed;

        }
        else
        {

            transform.eulerAngles += new Vector3(0, 10, 0) * Time.deltaTime * rotateSpeed;

        }

    }
}

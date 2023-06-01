using Enums;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonObject : PuzzleObjectRoot
{

    public bool isInput { get; set; } = false;

    public override void InteractionEvent(InteractionClickKey type)
    {

        if(type != InteractionClickKey.Left)
        {

            isInput = !isInput;

        }

    }

}

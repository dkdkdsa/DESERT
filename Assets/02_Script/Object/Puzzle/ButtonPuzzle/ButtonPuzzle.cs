using Struct;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ButtonPuzzle : PuzzleRoot
{

    [SerializeField] private List<ButtonPuzzleStruct> puzzleBtns = new List<ButtonPuzzleStruct>();
    [SerializeField] private UnityEvent clearEvt;

    private void Update()
    {

        bool value = false;

        foreach(var item in puzzleBtns)
        {

            if((item.isClickAble == false && item.btnObj.isInput == true)||
                (item.isClickAble == true && item.btnObj.isInput == false))
            {

                value = false;
                break;

            }
            else if(item.isClickAble == true && item.btnObj.isInput == true) 
            {

                value = true;

            }

        }

        if (value)
        {

            clearEvt?.Invoke();
            PuzzleClearEvent();

        }

    }

    public override void PuzzleClearEvent()
    {

        foreach(var item in puzzleBtns) 
        {

            Destroy(item.btnObj);

        }

        Destroy(this);

    }

}

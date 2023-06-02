using Enums;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonObject : PuzzleObjectRoot
{

    private bool isClickAnime;
    public bool isInput { get; set; } = false;

    public override void InteractionEvent(InteractionClickKey type)
    {

        if (isClickAnime) return;

        if(type == InteractionClickKey.Left)
        {

            
            isClickAnime = true;
            StartCoroutine(ClickAnimeCo());

        }

    }

    private IEnumerator ClickAnimeCo()
    {

        float per = 0;


        while(per < 1)
        {

            yield return null;
            per += Time.deltaTime * 10;
            transform.Translate((isInput ? -transform.forward : transform.forward) * Time.deltaTime);

        }
        isInput = !isInput;
        yield return new WaitForSeconds(0.5f);

        isClickAnime = false;

    }

}

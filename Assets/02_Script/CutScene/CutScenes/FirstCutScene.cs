using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstCutScene : CutSceneRoot
{
    public override void StartCutScene()
    {

        StartCoroutine(CutSceneCo());

    }

    private IEnumerator CutSceneCo()
    {



    }

}

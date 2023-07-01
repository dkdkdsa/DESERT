using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstCutScene : CutSceneRoot
{

    [SerializeField] private Transform camObject;

    public override void StartCutScene()
    {

        StartCoroutine(CutSceneCo());

    }

    private IEnumerator CutSceneCo()
    {

        yield return null;
        //yield return new WaitForSeconds(5f);

        float per = 0;

        while(per < 1)
        {

            per += Time.deltaTime * 0.5f;

            var vec = new Vector3(0, Mathf.Lerp(-0.4f, 1, per), 0);

            camObject.transform.position = vec;

        }

    }

}

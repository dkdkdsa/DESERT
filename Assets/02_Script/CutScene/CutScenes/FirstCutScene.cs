using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class FirstCutScene : CutSceneRoot
{

    [SerializeField] private Transform camObject;
    [SerializeField] private Volume fadeVolume;

    public override void StartCutScene()
    {

        StartCoroutine(CutSceneCo());

    }

    private IEnumerator CutSceneCo()
    {

        yield return new WaitForSeconds(2.5f);

        float per = 0;

        while(per < 1)
        {

            per += Time.deltaTime * 0.5f;

            var vec = new Vector3(0, Mathf.Lerp(-0.4f, 1, per), 0);

            fadeVolume.weight = 1 - (per / 5);
            camObject.transform.localPosition = vec;
            yield return null;

        }

        camObject.transform.localPosition = new Vector3(0, 1, 0);
        fadeVolume.gameObject.SetActive(false);

        CameraManager.instance.SetShake(0, 0);

        cutSceneEndEvent?.Invoke();

    }

}

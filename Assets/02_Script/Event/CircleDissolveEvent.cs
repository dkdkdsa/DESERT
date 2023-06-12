using AmazingAssets.AdvancedDissolve;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleDissolveEvent : EventRoot
{

    [SerializeField] private GameObject dissolveManageObject;
    [SerializeField] private Vector3 dissolveScale;
    [SerializeField] private float dissolveSpeed;

    private bool startingDissolve;

    public override void StartEvent()
    {

        if (startingDissolve) return;

        startingDissolve = true;

        CameraManager.instance.CameraShake(10f, 10f, 0.1f);
        StartCoroutine(StartDissolveCo());

    }

    private IEnumerator StartDissolveCo()
    {

        yield return null;

        float per = 0;

        while (per < 1) 
        { 
            
            per += Time.deltaTime * dissolveSpeed;
            dissolveManageObject.transform.localScale
                = Vector3.Lerp(dissolveManageObject.transform.localScale
                , dissolveScale, per);
            yield return null;
        
        }

        endEvent?.Invoke();

    }
}

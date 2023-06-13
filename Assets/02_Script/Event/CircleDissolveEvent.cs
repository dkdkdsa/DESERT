using AmazingAssets.AdvancedDissolve;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleDissolveEvent : EventRoot
{

    [SerializeField] private GameObject dissolveManageObject;
    [SerializeField] private Vector3 dissolveScale;
    [SerializeField] private string dissolveObjectKey;
    [SerializeField] private float dissolveSpeed;

    private bool isOn = false;

    public override void StartEvent()
    {

        isOn = !isOn;
        CameraManager.instance.CameraShake(10f, 10f, 0.1f);

        if (isOn)
        {

            StartCoroutine(StartDissolveCo());

        }
        else
        {

            StartCoroutine(EndDissolveCo());

        }


    }

    private IEnumerator StartDissolveCo()
    {

        yield return null;

        float per = 0;

        ObjectManager.instance.EnableObject(dissolveObjectKey);
        
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

    private IEnumerator EndDissolveCo()
    {

        yield return null;

        float per = 0;


        while (per < 1)
        {

            per += Time.deltaTime * 10;
            dissolveManageObject.transform.localScale
                = Vector3.Lerp(dissolveManageObject.transform.localScale
                , new Vector3(0.8f, 0.8f, 0.8f), per);
            yield return null;

        }
        ObjectManager.instance.DisableObject(dissolveObjectKey);

    }

}

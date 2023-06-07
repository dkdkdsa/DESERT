using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DissolveOnEvent : EventRoot
{

    [SerializeField] private float dissolveTime;
    [SerializeField] private Renderer[] dissolveRenderers;

    private void Start()
    {

        StartEvent();

    }

    public override void StartEvent()
    {

        StartCoroutine(DissolveOnCo());

    }

    private IEnumerator DissolveOnCo()
    {

        float per = 1;

        while(per > 0)
        {
            Debug.Log(per);
            per -= Time.deltaTime / dissolveTime;

            foreach(var item in dissolveRenderers) 
            {

                item.material.SetFloat("_AdvancedDissolveCutoutStandardClip", per);
            
            }

            yield return null;

        }

    }

}

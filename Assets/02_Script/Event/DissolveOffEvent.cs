using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DissolveOffEvent : EventRoot
{


    [SerializeField] private float dissolveTime;
    [SerializeField] private Renderer[] dissolveRenderers;

    public override void StartEvent()
    {

        StartCoroutine(DissolveOffCo());

    }

    private IEnumerator DissolveOffCo()
    {

        float per = 1;

        while (per > 0)
        {
            per -= Time.deltaTime / dissolveTime;

            foreach (var item in dissolveRenderers)
            {

                foreach(var mat in item.materials)
                {

                    mat.SetFloat("_AdvancedDissolveCutoutStandardClip", 1 - per);

                }


            }

            yield return null;

        }

        endEvent?.Invoke();

    }
}

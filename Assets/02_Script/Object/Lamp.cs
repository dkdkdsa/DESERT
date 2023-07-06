using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lamp : MonoBehaviour
{

    private Light lampLight;
    private Renderer lampRender;

    private void Awake()
    {
        
        lampLight = GetComponentInChildren<Light>();
        lampRender = GetComponent<Renderer>();

    }

    public void Show()
    {

        StartCoroutine(ShowEventCo());

    }

    private IEnumerator ShowEventCo()
    {

        float per = 0;

        while(per < 1)
        {

            per += Time.deltaTime * 0.1f;

            lampRender.materials[1].SetFloat("_EmissiveExposureWeight", 1 - per);
            lampLight.intensity = Mathf.Lerp(0, 131072, per);

            yield return null;

        }

        lampLight.intensity = 131072;
        lampRender.materials[1].SetFloat("_EmissiveExposureWeight", 0);

    }

}

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

        Debug.Log(lampLight.intensity);

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

            per += Time.deltaTime / 2;

            lampRender.materials[1].SetFloat("_EmissiveExposureWeight", 1 - per);

            lampLight.intensity = Mathf.Lerp(0, 20, per);

            //Debug.Log(lampLight.intensity);

            yield return null;

        }

        lampLight.intensity = 20;
        lampRender.materials[1].SetFloat("_EmissiveExposureWeight", 0);

    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lamp : MonoBehaviour
{

    private Light lampLight;
    private Renderer lampRender;

    private void Awake()
    {
        
        lampLight = transform.GetComponentInChildren<Light>();
        lampRender = GetComponent<Renderer>();

    }

    public void Show()
    {



    }

    private IEnumerator ShowEventCo()
    {

        float per = 0;


    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DarkZone : MonoBehaviour
{

    private PlayerValueSystem valueSystem;
    private Slider slider;
    private bool isFading;

    private void Awake()
    {
        
        valueSystem = FindObjectOfType<PlayerValueSystem>();

    }

    private void Start()
    {

        slider = UIManager.instance?.GetUIObject<Slider>("DarkGauge");

    }

    private void OnTriggerEnter(Collider collision)
    {

        if (isFading) return;

        valueSystem.isCharging = true;

        slider.value = 1;

        if (collision.transform.CompareTag("Player") && !valueSystem.darkMode)
        {

            valueSystem.darkMode = true;
            valueSystem.darkGauge = 1;
            isFading = true;
            StartCoroutine(VolumeFadeCo());

        }
        else if (valueSystem.darkMode)
        {

            valueSystem.darkGauge = 1;

        }

    }

    private void OnTriggerExit(Collider other)
    {

        valueSystem.isCharging = false;

    }

    private IEnumerator VolumeFadeCo()
    {

        float per = 0;
        
        while(per < 1)
        {

            per += Time.deltaTime;
            ObjectManager.instance.darkVolume.weight = per;

            yield return null;

        }

        ObjectManager.instance.darkVolume.weight = 1;
        isFading = false;

    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerDarkMode : PlayerBehaviorRoot
{

    private Slider slider;

    private void Start()
    {

        slider = UIManager.instance.GetUIObject<Slider>("DarkGauge");

    }

    private void DrakGaugeDissolve()
    {

        if (!valueSystem.darkMode || valueSystem.isCharging) return;

        var horVec = Input.GetAxisRaw("Horizontal");
        var vetVec = Input.GetAxisRaw("Vertical");

        float rootVec = Mathf.Abs(horVec) + Mathf.Abs(vetVec);

        rootVec = Mathf.Clamp(rootVec, 0, 1);

        slider.value = valueSystem.darkGauge;

        if(rootVec > 0)
        {

            valueSystem.darkGauge -= Time.deltaTime * 0.1f;

        }
        
        if(valueSystem.darkGauge <= 0)
        {

            valueSystem.darkMode = false;
            StartCoroutine(DarkDissolveCo());
            DarkModeManager.instance?.SetMode(false);

        }

    }

    private IEnumerator DarkDissolveCo()
    {

        float per = 1;

        while (per > 0)
        {

            per -= Time.deltaTime;
            ObjectManager.instance.darkVolume.weight = per;
            yield return null;

            if (valueSystem.darkMode) break;

        }

    }

    public override void AddEvent()
    {

        eventSystem.OnUpdateEvent += DrakGaugeDissolve;

    }

    public override void RemoveEvent()
    {

        eventSystem.OnUpdateEvent -= DrakGaugeDissolve;

    }
}
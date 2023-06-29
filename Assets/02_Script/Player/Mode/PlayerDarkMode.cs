using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDarkMode : PlayerBehaviorRoot
{

    private void DrakGaugeDissolve()
    {

        if (!valueSystem.darkMode) return;

        var horVec = Input.GetAxisRaw("Horizontal");
        var vetVec = Input.GetAxisRaw("Vertical");

        float rootVec = Mathf.Abs(horVec) + Mathf.Abs(vetVec);

        rootVec = Mathf.Clamp(rootVec, 0, 1);

        if(rootVec > 0)
        {

            valueSystem.darkGauge -= Time.deltaTime * 0.01f;

        }
        else
        {

            valueSystem.darkMode = false;
            StartCoroutine(DarkDissolveCo());

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